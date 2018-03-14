using System;
using System.Collections.Generic;

namespace PDSI.SmarterTrackClient
{
    public partial class StFiles
    {
        public StFiles()
        {
            StBrandsFileIdFaviconNavigation = new HashSet<StBrands>();
            StBrandsFileIdVoipIconNavigation = new HashSet<StBrands>();
            StBrandsFileIdVoipRingToneNavigation = new HashSet<StBrands>();
            StBrandsPublicSiteLogoFile = new HashSet<StBrands>();
            StChatImageConfigsFileIdOfflineImageNavigation = new HashSet<StChatImageConfigs>();
            StChatImageConfigsFileIdOnlineImageNavigation = new HashSet<StChatImageConfigs>();
            StTicketMessages = new HashSet<StTicketMessages>();
            StUsers = new HashSet<StUsers>();
        }

        public int FileId { get; set; }
        public int? FileDirectoryId { get; set; }
        public string FileNameOriginal { get; set; }
        public string FileNameOnDisk { get; set; }
        public int Length { get; set; }
        public long Crc { get; set; }
        public int CompressionType { get; set; }

        public StFileDirectories FileDirectory { get; set; }
        public ICollection<StBrands> StBrandsFileIdFaviconNavigation { get; set; }
        public ICollection<StBrands> StBrandsFileIdVoipIconNavigation { get; set; }
        public ICollection<StBrands> StBrandsFileIdVoipRingToneNavigation { get; set; }
        public ICollection<StBrands> StBrandsPublicSiteLogoFile { get; set; }
        public ICollection<StChatImageConfigs> StChatImageConfigsFileIdOfflineImageNavigation { get; set; }
        public ICollection<StChatImageConfigs> StChatImageConfigsFileIdOnlineImageNavigation { get; set; }
        public ICollection<StTicketMessages> StTicketMessages { get; set; }
        public ICollection<StUsers> StUsers { get; set; }
    }
}
