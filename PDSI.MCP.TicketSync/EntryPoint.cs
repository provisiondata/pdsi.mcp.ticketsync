using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Serilog;
using StructureMap;

namespace PDSI.MCP.TicketSync
{
    class EntryPoint
    {
        private static ILogger _log;
        private static TicketSyncConfig _configuration;

        static Int32 Main(String[] args)
        {
            using (var container = new Container(new TicketSyncRegistry()))
            {
                Init(container);

                var result = 0;
                if (args.Length > 0)
                {
                    result = DoCommandLine(args, container);
                }
                else
                {
                    result = RunAsync(container).GetAwaiter().GetResult();
                }

                DebuggerWait();
                return result;
            }
        }

        private static Int32 DoCommandLine(String[] args, Container container)
        {
            if (args.Contains("--list-jobs", StringComparer.InvariantCultureIgnoreCase))
            {
                return ListJobs(container);
            }

            return 0;
        }

        private static void DebuggerWait()
        {
            if (Debugger.IsAttached)
            {
                Console.WriteLine("Looks like you're debugging.  Press ENTER to EXIT . . .");
                Console.ReadLine();
            }
        }

        private static void Init(Container container)
        {
            try
            {
                _configuration = container.GetInstance<IConfiguration>().GetSection(TicketSyncConfig.SectionName).Get<TicketSyncConfig>();
                _log = container.GetInstance<ILogger>();
                _log.Information($"TicketSync Running: {DateTimeOffset.Now} {Environment.GetEnvironmentVariable("MCP_ENVIRONMENT") ?? "Production"}");
                _log.Verbose(container.WhatDidIScan());
                _log.Verbose(container.WhatDoIHave());
                StructureMap.Graph.Scanning.TypeRepository.AssertNoTypeScanningFailures();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.GetType() + ": " + ex.Message);
                throw;
            }
        }

        private static async Task<Int32> RunAsync(Container container)
        {
            try
            {
                foreach (var job in container.GetAllInstances<IJob>())
                {
                    try
                    {
                        if (IsEnabled(job))
                        {
                            _log.Information($"TicketSync Started: {job}");
                            var result = await job.ExecuteAsync();
                            _log.Information($"TicketSync Finished: {job}");
                        }
                        else
                        {
                            _log.Information($"TicketSync {job} is disabled");
                        }
                    }
                    catch (Exception exception)
                    {
                        exception.Visit(ex => _log.Error(ex, ex.Message));
                    }
                }

                return 0; // No Errors
            }
            catch (Exception exception)
            {
                exception.Visit(ex => _log.Fatal(ex, ex.Message));
                return 1; // Error
            }
        }

        private static Int32 ListJobs(Container container)
        {
            foreach (var job in container.GetAllInstances<IJob>())
            {
                _log.Information("Job: {Job} Enabled: {State}", job.GetType().Name, IsEnabled(job));
            }

            return 0;
        }

        private static Boolean IsEnabled(IJob job)
        {
            var info = _configuration.Jobs.SingleOrDefault(j => String.Equals(j.Name, job.GetType().Name, StringComparison.InvariantCultureIgnoreCase));
            return info == null ? true : info.Enabled;
        }
    }
}
