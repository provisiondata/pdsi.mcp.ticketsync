using Serilog;

namespace PDSI.MCP.TicketSync
{
	public interface IJob
	{
		JobResult Execute();
	}

	public abstract class Job : IJob
	{
		protected Job(ILogger logger) {
			Logger = logger;
		}

		protected ILogger Logger { get; }

		public abstract JobResult Execute();
	}
}
