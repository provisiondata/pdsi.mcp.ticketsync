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
    }
}
