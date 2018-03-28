using System.Data;

namespace PDSI.SmarterTrackClient
{
	public interface ISmarterTrackContext
	{
		SmarterTrack Config { get; }
		IDbConnection Connection { get; }
	}

	public class SmarterTrackContext : ISmarterTrackContext
	{
		private readonly IDbConnection _connection;
		private readonly SmarterTrack _config;

		public SmarterTrackContext(IDbConnection connection, SmarterTrack config)
		{
			_connection = connection;
			_config = config;
		}
		public IDbConnection Connection => _connection;
		public SmarterTrack Config => _config;
	}
}
