using System.Data.Common;
using System.Threading.Tasks;
using Dapper;
using PDSI.SmarterTrackClient;
using Serilog;

namespace PDSI.MCP.TicketSync.Jobs
{
    public class UpdateSmarterTrackSoc2CommentType : Job
    {
        private readonly ISmarterTrackContext _smarterTrack;

        public UpdateSmarterTrackSoc2CommentType(ILogger logger, ISmarterTrackContext smarterTrack) : base(logger)
        {
            _smarterTrack = smarterTrack;
        }

        public override async Task<JobResult> ExecuteAsync()
        {
            using (var transaction = _smarterTrack.Connection.BeginTransaction())
            {
                try
                {
                    await _smarterTrack.Connection.ExecuteAsync("UPDATE [st_TicketComments] SET [CommentTypeID] = 5 WHERE [CommentTypeID] != 5 AND [CommentText] LIKE '%#SOC2%'", transaction: transaction);
                    transaction.Commit();
                }
                catch (DbException ex)
                {
                    transaction.Rollback();
                    Logger.Error(ex, "Failed to update SmarterTrack SOC2 Comment Types");
                    throw;
                }
            }

            return new JobResult() { };
        }
    }
}
