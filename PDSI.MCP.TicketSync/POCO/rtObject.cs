using System;

namespace PDSI.MCP.TicketSync
{
	public class rtObject
	{
		public String name { get; set; }
		public String label { get; set; }
		public String asset_no { get; set; }
		public String comment { get; set; }
		public Int32 id { get; set; }
		public Int32 objtype_id { get; set; }

		public override String ToString() => $"{nameof(rtObject)} [{id}] {name} <{label}>";
	}
}
