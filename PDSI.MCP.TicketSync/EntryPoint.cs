using System;
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
				var result = RunAsync(container).GetAwaiter().GetResult();
				return result;
			}
		}

		private static void Init(Container container)
		{
			try
			{
				_configuration = container.GetInstance<IConfiguration>().GetSection(TicketSyncConfig.SectionName).Get<TicketSyncConfig>();
				_log = container.GetInstance<ILogger>();
				_log.Information($"TicketSync Running: {DateTimeOffset.Now}");
				_log.Verbose(container.WhatDidIScan());
				_log.Verbose(container.WhatDoIHave());
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
				foreach(var job in container.GetAllInstances<IJob>())
				{
					try {
						if (IsEnabled(job)) {
							_log.Information($"TicketSync Started: {job}");
							var result = await job.Execute();
							_log.Information($"TicketSync Finished: {job}");
						} else {
							_log.Information($"TicketSync {job} is disabled");
						}
					}
					catch (Exception exception) {
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

		private static Boolean IsEnabled(IJob job)
		{
			var info = _configuration.Jobs.SingleOrDefault(j => String.Equals(j.Name, job.GetType().Name, StringComparison.InvariantCultureIgnoreCase));
			return info == null ? true : info.Enabled;
		}
	}
}
