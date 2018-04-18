using Microsoft.Extensions.Configuration;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PDSI.SmarterTrackClient
{
    public class SmarterTrackRegistry : Registry
    {
        public SmarterTrackRegistry()
        {
            For<ISmarterTrackContext>()
                .LifecycleIs<TransientLifecycle>()
                .Use(ctx => new SmarterTrackContext(GetSqlServerConnection(
                    ctx.GetInstance<IConfiguration>().GetConnectionString("SmarterTrack")), 
                    ctx.GetInstance<IConfiguration>().GetSection(nameof(SmarterTrack)).Get<SmarterTrack>()));

        }

        static IDbConnection GetSqlServerConnection(String connectionString)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }

    public interface ISmarterTrackContext
    {
        SmarterTrack Config { get; }
        IDbConnection Connection { get; }
    }

    public class SmarterTrackContext : ISmarterTrackContext
    {
        public SmarterTrackContext(IDbConnection connection, SmarterTrack config)
        {
            Connection = connection;
            Config = config;
        }
        public IDbConnection Connection { get; }

        public SmarterTrack Config { get; }
    }

    public class SmarterTrack
    {
        public String EndpointAddress { get; set; }
        public String AuthUserName { get; set; }
        public String AuthPassword { get; set; }
        public Int32 PdsiMcpUserId { get; set; }
        public Int32 AssetCustomFieldId { get; set; }
        public Int32 AccountCustomFieldId { get; set; }
        public String AccountUrlTemplate { get; set; }
        public String AssetUrlTemplate { get; set; }
        public Boolean GenerateHtmlComments { get; set; }
        public String MessageType { get; set; } = "general";
        public Int32 TicketScanLimit { get; set; } = 500;
    }

    public class StCustomField
    {
        public String Name { get; set; }
        public String Value { get; set; }
    }

    public static class Extensions
    {
        public static StCustomField ParseCustomField(this String s)
        {
            var r = s.Split(new[] { '=' }, 2, StringSplitOptions.None);
            return new StCustomField() { Name = r[0], Value = r[1] };
        }
    }
}
