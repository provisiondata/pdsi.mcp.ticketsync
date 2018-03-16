using System;
using PDSI.MCP.TicketSync.Jobs;
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

				return Run(container);
			}
		}

		private static void InitLogging(Container container)
		{
			try
			{
				_log = container.GetInstance<ILogger>();
				_log.Debug(container.WhatDidIScan());
				_log.Debug(container.WhatDoIHave());
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.GetType() + ": " + ex.Message);
				throw;
			}
		}

		private static Int32 Run(Container container)
		{
			try
			{
				foreach(var job in container.GetAllInstances<IJob>())
				{
					_log.Information($"Starting: {job.GetType()}");
					var result = job.Execute();
					_log.Information($"Stopped: {job.GetType()}");
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
