using Humanizer;
using Serilog;
using System;
using System.Threading.Tasks;

namespace PDSI.MCP.TicketSync
{
	public interface IJob
	{
		String Name { get; }
		Task<JobResult> Execute();
	}

	public abstract class Job : IJob
	{
		protected Job(ILogger logger) {
			Logger = logger;
		}

		public virtual String Name => GetType().Name.Humanize(LetterCasing.Title);

		protected ILogger Logger { get; }

		public abstract Task<JobResult> Execute();

		public override String ToString() => Name;
	}
}
