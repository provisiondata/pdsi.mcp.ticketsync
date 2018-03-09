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
				var row = vTiger.Query("SELECT * FROM vtiger_account").FirstOrDefault();
				log.Information(row.ToString());
			}

			using (var racktables = GetRacktablesConnection()) {
				var row = racktables.Query("SELECT * FROM Object").FirstOrDefault();
				log.Information(row.ToString());
			}

			using (var smarterTrack = GetSmarterTrackConnection()) {
				var row = smarterTrack.Query("SELECT * FROM [SmarterTrack].[dbo].[st_Tickets]").FirstOrDefault();
				log.Information(row.ToString());
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

			Console.Write("Tickets Returned:" + result.Body.GetTicketsBySearchResult.Tickets.Count());

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