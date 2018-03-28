using System.Data;

namespace PDSI.MCP.TicketSync
{
	public interface IVTigerContext
	{
		IDbConnection Connection { get; }
	}

	public class VTigerContext : IVTigerContext
	{
		private readonly IDbConnection _connection;

		public VTigerContext(IDbConnection connection)
		{
			_connection = connection;
		}
		public IDbConnection Connection => _connection;
	}
}