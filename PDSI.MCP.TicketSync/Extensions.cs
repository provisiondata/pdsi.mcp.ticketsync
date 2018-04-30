using PDSI.SmarterTrackClient;
using Serilog;
using System;

namespace PDSI.MCP.TicketSync
{
	public static class Extensions
	{
		public static void Visit(this Exception ex, Action<Exception> action)
		{
			action(ex);
			var iex = ex.InnerException;
			while (iex != null)
			{
				action(iex);
				iex = iex.InnerException;
			}
		}

        public static Int32 Id(this String s)
        {
            var start = s.LastIndexOf('[');
            if (start >= 0)
            {
                var end = s.LastIndexOf(']');
                if (end > start)
                {
                    var v = s.Substring(start + 1, end - 1 - start);
                    if (Int32.TryParse(v, out var id))
                    {
                        return id;
                    }
                }
            }
            return -1;
        }

        public static String Left(this String s, Int32 l)
        {
            if (s is null) return null;
            if (String.IsNullOrWhiteSpace(s)) return String.Empty;
            return s.Substring(0, s.Length < l ? s.Length : l);
        }

        public static void LogTicket(this ILogger logger, Int32 counter, TicketInfo ticket)
        {
            logger.Verbose("{Count,5:N0} Ticket [{TicketNumber}] {LastReplyDateUtc} Active:{IsActive,5} Open:{IsOpen,5} Deleted:{IsDeleted} D:{IdDepartment} G:{IdGroup} U:{IdAgent} {Subject:S50}",
                counter, ticket.TicketNumber, ticket.LastReplyDateUtc, ticket.IsActive, ticket.IsOpen, ticket.IsDeleted,
                ticket.IdDepartment, ticket.IdGroup, ticket.IdAgent, ticket.Subject.Left(100));
        }
    }
}
