using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StChatImageConfigs
    {
        public StChatImageConfigs()
        {
            StDepartmentsInChatImageConfigs = new HashSet<StDepartmentsInChatImageConfigs>();
        }

        public int ChatImageConfigId { get; set; }
        public int? FileIdOnlineImage { get; set; }
        public int? FileIdOfflineImage { get; set; }
        public string Title { get; set; }
        public string OnlineCssTag { get; set; }
        public string OnlineImageHref { get; set; }
        public string OnlineText { get; set; }
        public string OnlineUrl { get; set; }
        public string OnlineTarget { get; set; }
        public string OfflineCssTag { get; set; }
        public string OfflineImageHref { get; set; }
        public string OfflineText { get; set; }
        public string OfflineUrl { get; set; }
        public string OfflineTarget { get; set; }
        public int? RefreshSeconds { get; set; }
        public string OnlineLinkTitle { get; set; }
        public string OfflineLinkTitle { get; set; }
        public DateTime? DateLastChangedUtc { get; set; }
        public int? Type { get; set; }
        public int? Position { get; set; }
        public string HeaderColorOnline { get; set; }
        public string HeaderColorOffline { get; set; }
        public string BodyColor { get; set; }
        public short OnlineDisplayAs { get; set; }
        public short OfflineDisplayAs { get; set; }
        public string OnlineImageType { get; set; }
        public string OfflineImageType { get; set; }
        public string FirstMessageTextOnline { get; set; }
        public string FirstMessageTextOffline { get; set; }
        public string ChatStyle { get; set; }

        public StFiles FileIdOfflineImageNavigation { get; set; }
        public StFiles FileIdOnlineImageNavigation { get; set; }
        public ICollection<StDepartmentsInChatImageConfigs> StDepartmentsInChatImageConfigs { get; set; }
    }
}
