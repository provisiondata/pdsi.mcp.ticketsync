using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using PDSI.SmarterTrackClient;
using Serilog;
using www.smartertools.com.SmarterTrack.Services2.svcTickets.asmx;

namespace PDSI.MCP.TicketSync
{
	class EntryPoint
	{
		static Int32 Main(String[] args) {
			Console.WriteLine($"Environment.CurrentDirectory: {Environment.CurrentDirectory}");

			var log = GetLogger();

			using (var vTiger = GetVTigerConnection()) {
				var rows = vTiger.Query<vtAccount>("SELECT * FROM vtiger_account").OrderBy(a => a.accountname).Select(a => $"{a.accountname} [{a.accountid}]");
				log.Verbose(String.Join("\n", rows));
				log.Information("Successfully Connected to vTiger Database");
			}

			using (var racktables = GetRacktablesConnection()) {
				var rows = racktables.Query<rtObject>("SELECT * FROM Object");
				//foreach(var row in rows) {
				//	log.Information("[{id}] {name} <{label}>", row.id, row.name, row.label);
				//}
				log.Information("Successfully Connected to Racktables Database");
			}

			using (var smarterTrack = GetSmarterTrackConnection()) {
				var rows = smarterTrack.Query<StTickets>("SELECT * FROM [st_Tickets]").Take(100);
				//foreach(var row in rows) {
				//	log.Verbose("[{TicketNumber}] {Subject} <{CustomerEmailAddress}>", row.TicketNumber, row.Subject, row.CustomerEmailAddress);
				//}
				log.Information("Successfully Connected to SmarterTrack Database");
			}

			var smConfig = Configuration.GetSection(nameof(SmarterTrack)).Get<SmarterTrack>();
			Binding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
			var factory = new ChannelFactory<svcTicketsSoap>(binding, new EndpointAddress($"{smConfig.EndpointAddress}/Services2/svcTickets.asmx"));
			var serviceProxy = factory.CreateChannel();
			var body = new GetTicketsBySearchRequestBody() {
				authUserName = smConfig.AuthUserName,
				authPassword = smConfig.AuthPassword,
				searchCriteria = new ArrayOfString() { "GroupId=4" }
			};
			var request = new GetTicketsBySearchRequest(body);
			var result = serviceProxy.GetTicketsBySearch(request);
			log.Information("Successfully Connected to SmarterTrack Webservice");

			if (Debugger.IsAttached) {
				Console.WriteLine("Press ENTER to EXIT . . .");
				Console.ReadLine();
			}

			return 0;
		}

		private static ILogger GetLogger() {
			return new LoggerConfiguration()
				.ReadFrom.Configuration(Configuration)
				.CreateLogger();
		}

		public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
			.SetBasePath(Environment.CurrentDirectory)
			.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
			.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("MCP_ENVIRONMENT") ?? "Production"}.json", optional: true, reloadOnChange: true)
			.AddEnvironmentVariables()
			.Build();

		static IDbConnection GetVTigerConnection() => GetMySqlConnection(Configuration.GetConnectionString("vTiger"));
		static IDbConnection GetRacktablesConnection() => GetMySqlConnection(Configuration.GetConnectionString("Racktables"));
		static IDbConnection GetSmarterTrackConnection() => GetSqlServerConnection(Configuration.GetConnectionString("SmarterTrack"));

		static MySqlConnection GetMySqlConnection(String connectionString) {
			var connection = new MySqlConnection(connectionString);
			connection.Open();
			return connection;
		}

		static SqlConnection GetSqlServerConnection(String connectionString) {
			var connection = new SqlConnection(connectionString);
			connection.Open();
			return connection;
		}
	}
}