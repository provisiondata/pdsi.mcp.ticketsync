using Dapper;
using PDSI.SmarterTrackClient;
using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PDSI.MCP.TicketSync.Jobs
{
	public class UpdateVTigerAccountsInSmarterTrack : Job
	{
		private readonly IVTigerContext _vTiger;
		private readonly ISmarterTrackContext _smarterTrack;

		public UpdateVTigerAccountsInSmarterTrack(ILogger logger, IVTigerContext vTiger, ISmarterTrackContext smarterTrack)
			: base(logger)
		{
			_vTiger = vTiger;
			_smarterTrack = smarterTrack;
		}

		public override async Task<JobResult> ExecuteAsync()
		{
			try {
				var accounts = await _vTiger.Connection.QueryAsync<vtAccount>("SELECT * FROM vtiger_account");
				var options = accounts.OrderBy(a => a.accountname).Select(a => $"{a.accountname} [{a.accountid}]");
				var cdf = new StCustomDataFields() {
					CustomFieldId = _smarterTrack.Config.AccountCustomFieldId,
					Options = String.Join("\n", options)
				};

				// Update
				using (var transaction = _smarterTrack.Connection.BeginTransaction()) {
					await _smarterTrack.Connection.ExecuteAsync("UPDATE [st_CustomDataFields] SET [Options] = @Options WHERE [CustomFieldId] = @CustomFieldId", cdf, transaction);
					transaction.Commit();
				}
			} 
			catch(Exception ex) {
				Logger.Error("Something bad happened.", ex);
			}

			return new JobResult() { };
		}
	}
}
