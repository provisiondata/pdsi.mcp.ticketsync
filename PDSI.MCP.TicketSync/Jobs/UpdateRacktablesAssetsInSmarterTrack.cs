using System;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
	public class UpdateRackTablesAssetsInSmarterTrack : Job
	{
		private readonly IRackTablesContext _rackTables;
		private readonly ISmarterTrackContext _smarterTrack;

		public UpdateRackTablesAssetsInSmarterTrack(ILogger logger, IRackTablesContext vTiger, ISmarterTrackContext smarterTrack)
			: base(logger)
		{
			_rackTables = vTiger;
			_smarterTrack = smarterTrack;
		}

		public override async Task<JobResult> ExecuteAsync()
		{
			try {
				var objects = await _rackTables.Connection.QueryAsync<rtObject>("SELECT * FROM Object");
				var options = objects.OrderBy(a => a.name).Select(a => $"{a.name} [{a.id}]").ToList();
                options.Insert(0, "/dev/null [0]");
                var cdf = new StCustomDataFields() {
					CustomFieldId = _smarterTrack.Config.AssetCustomFieldId,
					Options = String.Join("\n", options)
				};

				// Update
				using (var transaction = _smarterTrack.Connection.BeginTransaction()) {
					await _smarterTrack.Connection.ExecuteAsync("UPDATE [st_CustomDataFields] SET [Options] = @Options WHERE [CustomFieldId] = @CustomFieldId", cdf, transaction);
					transaction.Commit();
				}
			}
			catch (Exception ex) {
				Logger.Error("Something bad happened.", ex);
			}

			return new JobResult() { };
		}
	}
}