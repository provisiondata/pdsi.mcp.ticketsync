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

        public static String Id(this String s)
        {
            var start = s.LastIndexOf('[');
            if (start >= 0)
            {
                var end = s.LastIndexOf(']');
                if (end > start)
                {
                    return s.Substring(start + 1, end - 1 - start);
                }
            }
            return String.Empty;
        }
    }
}
