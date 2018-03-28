using System;

namespace PDSI.SmarterTrackClient
{
	public class SmarterTrack {
		public String EndpointAddress { get; set; }
		public String AuthUserName { get; set; }
		public String AuthPassword { get; set; }
		public Int32 PdsiMcpUserId { get; set; }
		public Int32 AssetCustomFieldId { get; set; }
		public Int32 AccountCustomFieldId { get; set; }
	}
}
