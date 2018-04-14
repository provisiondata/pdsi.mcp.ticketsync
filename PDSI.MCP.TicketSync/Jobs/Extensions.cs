using System;

namespace PDSI.MCP.TicketSync.Jobs
{
    public static class Extensions
    {
        public static CustomField ParseCustomField(this String s)
        {
            var r = s.Split('=', 2, StringSplitOptions.None);
            return new CustomField() { Name = r[0], Value = r[1] };
        }
    }
}
