using Serilog;
using System;

namespace PDSI.MCP.TicketSync.Jobs
{
	public class UpdateSmarterTrackCustomFields : Job
	{
		private readonly IVTigerConnection _vTiger;
		private readonly IRactablesConnection _racktables;
		private readonly ISmarterTrackConnection _smarterTrack;

		public UpdateSmarterTrackCustomFields(ILogger logger, IVTigerConnection vTiger, IRactablesConnection racktables, ISmarterTrackConnection smarterTrack)
			: base(logger)
		{
			_vTiger = vTiger;
			_racktables = racktables;
			_smarterTrack = smarterTrack;
		}

		public override JobResult Execute()
		{
			throw new NotImplementedException();
		}
	}
}
