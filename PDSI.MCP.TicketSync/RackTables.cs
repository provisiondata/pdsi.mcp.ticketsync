using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Data;

namespace PDSI.MCP.TicketSync
{
    public class RackTablesRegistry : Registry
    {
        public RackTablesRegistry()
        {
            For<IRackTablesContext>()
                .LifecycleIs<TransientLifecycle>()
                .Use(ctx => new RackTablesContext(GetMySqlConnection(
                    ctx.GetInstance<IConfiguration>().GetConnectionString("RackTables")),
                    ctx.GetInstance<IConfiguration>().GetSection(nameof(RackTables)).Get<RackTables>()));

        }

        static IDbConnection GetMySqlConnection(String connectionString)
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }

    public interface IRackTablesContext
	{
		IDbConnection Connection { get; }
        RackTables Config { get; }
    }

	public class RackTablesContext : IRackTablesContext
	{

		public RackTablesContext(IDbConnection connection, RackTables config)
		{
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
            Config = config ?? throw new ArgumentNullException(nameof(config));
        }

        public IDbConnection Connection { get; }
        public RackTables Config { get; }
    }

    public class RackTables
    {
        public String AuthUserName { get; set; }
        public String AuthPassword { get; set; }
        public Boolean GenerateHtmlComments { get; set; }
        public String AccountUrlTemplate { get; set; }
        public String TicketUrlTemplate { get; set; }
        public Int32 TicketScanLimit { get; set; } = 500;
    }

    [Table("Object")]
    public class rtObject
    {
        public UInt32 id { get; set; }
        public String name { get; set; }
        public String label { get; set; }
        public Int32 objtype_id { get; set; }
        public String asset_no { get; set; }
        public String comment { get; set; }

        public override String ToString() => $"{nameof(rtObject)} [{id}] {name} <{label}>";
    }

    [Table("ObjectLog")]
    public class rtObjectLog
    {
        public Int32 id { get; set; }
        public Int32 object_id { get; set; }
        public String user { get; set; }
        public DateTime date { get; set; }
        public String content { get; set; }
    }
}
