using System;
using System.Collections.Generic;

namespace PDSI.MCP.TicketSync
{
	public class TicketSyncConfig
	{
		public static readonly String SectionName = "TicketSync";

		public IEnumerable<JobInfo> Jobs { get; set; }
	}
}
