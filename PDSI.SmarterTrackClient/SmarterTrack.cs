using System;

namespace PDSI.SmarterTrackClient
{
	public class SmarterTrack {
		public String EndpointAddress { get; set; }
		public String AuthUserName { get; set; } = "pdsimcp";
		public String AuthPassword { get; set; }
		public Int32 PdsiMcpUserId { get; set; } = 14;
		public Int32 AssetCustomFieldId { get; set; } = 4;
		public Int32 VTigerAccountCustomFieldId { get; set; } = 6;
	}
}
