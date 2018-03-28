using System.Data;

namespace PDSI.MCP.TicketSync
{
	public interface IRactablesContext
	{
		IDbConnection Connection { get; }
	}

	public class RactablesContext : IRactablesContext
	{
		private readonly IDbConnection _connection;

		public RactablesContext(IDbConnection connection)
		{
			_connection = connection;
		}
		public IDbConnection Connection => _connection;
	}
}
