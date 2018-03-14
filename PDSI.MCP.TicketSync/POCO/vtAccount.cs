using System;

namespace PDSI.MCP.TicketSync
{
	public class vtAccount
	{
		public String account_no { get; set; }
		public String accountname { get; set; }
		public String account_type { get; set; }
		public String industry { get; set; }
		public String rating { get; set; }
		public String ownership { get; set; }
		public String siccode { get; set; }
		public String tickersymbol { get; set; }
		public String phone { get; set; }
		public String otherphone { get; set; }
		public String email1 { get; set; }
		public String email2 { get; set; }
		public String website { get; set; }
		public String fax { get; set; }
		public String emailoptout { get; set; }
		public String notify_owner { get; set; }
		public String accountbillinginvoice { get; set; }
		public Int32 accountid { get; set; }
		public Int32 parentid { get; set; }
		public Int32 annualrevenue { get; set; }
		public Int32 employees { get; set; }

		public override String ToString() => $"{nameof(vtAccount)} [{account_no}] {accountname} <{accountid}>";
	}
}
