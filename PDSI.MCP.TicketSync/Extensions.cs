using System;

namespace PDSI.MCP.TicketSync
{
	static class Extensions
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
	}
}
