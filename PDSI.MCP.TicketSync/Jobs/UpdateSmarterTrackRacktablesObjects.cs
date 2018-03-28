using System.Threading.Tasks;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
	public class UpdateSmarterTrackRacktablesObjects : Job
	{
		protected UpdateSmarterTrackRacktablesObjects(ILogger logger) : base(logger)
		{
		}

		public override Task<JobResult> Execute() => Task.FromResult(new JobResult());
	}
}
