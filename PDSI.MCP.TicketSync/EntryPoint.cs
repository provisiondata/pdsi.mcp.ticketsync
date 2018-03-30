using System;
using System.Threading.Tasks;
using Serilog;
using StructureMap;

namespace PDSI.MCP.TicketSync
{
	class EntryPoint
	{
		private static ILogger _log;

		static Int32 Main(String[] args)
		{
			using (var container = new Container(new TicketSyncRegistry()))
			{
				InitLogging(container);
				var result = RunAsync(container).GetAwaiter().GetResult();
				return result;
			}
		}

		private static void InitLogging(Container container)
		{
			try
			{
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
						_log.Information($"TicketSync Started: {job}");
						var result = await job.Execute();
						_log.Information($"TicketSync Finished: {job}");
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
	}
}
