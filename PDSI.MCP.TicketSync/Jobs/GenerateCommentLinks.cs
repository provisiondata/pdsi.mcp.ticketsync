using System;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
	public class GenerateSmarterTrackCommentLinks : Job
	{
		private readonly ISmarterTrackContext _smarterTrack;

		public GenerateSmarterTrackCommentLinks(ILogger logger, ISmarterTrackContext smarterTrack) : base(logger)
		{
			_smarterTrack = smarterTrack;
		}

		public override async Task<JobResult> Execute()
		{
			var webService = new svcTicketsSoapClient(svcTicketsSoapClient.EndpointConfiguration.svcTicketsSoap12, _smarterTrack.Config.EndpointAddress);
			var result = await webService.GetTicketsBySearchAsync(_smarterTrack.Config.AuthUserName, _smarterTrack.Config.AuthPassword, new ArrayOfString());

			Logger.Debug($"Found {result.Body.GetTicketsBySearchResult.Tickets.Length} tickets.");
			// List recent tickets

			// For each ticket

			// If custom field is set

			// If pinned comment doesn't exist

			// Generate comment

			// Update comment
			return new JobResult() { };
		}
	}
}
