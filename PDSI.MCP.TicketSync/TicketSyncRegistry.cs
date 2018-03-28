using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using PDSI.SmarterTrackClient;
using Serilog;
using StructureMap;
using StructureMap.Pipeline;

namespace PDSI.MCP.TicketSync
{
	internal class TicketSyncRegistry : Registry
	{
		public TicketSyncRegistry()
		{
			Scan(_ => {
				_.TheCallingAssembly();
				_.WithDefaultConventions();
				_.AddAllTypesOf<IJob>();
			});

			For<IConfiguration>()
				.LifecycleIs<SingletonLifecycle>()
				.Use(ctx => new ConfigurationBuilder()
					.SetBasePath(Environment.CurrentDirectory)
					.AddJsonFile("appsettings.json", false, true)
					.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("MCP_ENVIRONMENT") ?? "Production"}.json", true, true)
					.AddEnvironmentVariables()
					.Build());

			For<ILogger>()
				.LifecycleIs<SingletonLifecycle>()
				.Use(ctx => new LoggerConfiguration()
					.ReadFrom.Configuration(ctx.GetInstance<IConfiguration>(), null)
					.CreateLogger());

			For<IVTigerContext>()
				.LifecycleIs<TransientLifecycle>()
				.Use(ctx => new VTigerContext(GetMySqlConnection(ctx.GetInstance<IConfiguration>().GetConnectionString("vTiger"))));

			For<IRactablesContext>()
				.LifecycleIs<TransientLifecycle>()
				.Use(ctx => new RactablesContext(GetMySqlConnection(ctx.GetInstance<IConfiguration>().GetConnectionString("Racktables"))));

			For<ISmarterTrackContext>()
				.LifecycleIs<TransientLifecycle>()
				.Use(ctx => new SmarterTrackContext(GetSqlServerConnection(ctx.GetInstance<IConfiguration>().GetConnectionString("SmarterTrack")), ctx.GetInstance<IConfiguration>().GetSection(nameof(SmarterTrack)).Get<SmarterTrack>()));
		}

		static IDbConnection GetMySqlConnection(String connectionString)
		{
			var connection = new MySqlConnection(connectionString);
			connection.Open();
			return connection;
		}

		static IDbConnection GetSqlServerConnection(String connectionString)
		{
			var connection = new SqlConnection(connectionString);
			connection.Open();
			return connection;
		}
	}
}
