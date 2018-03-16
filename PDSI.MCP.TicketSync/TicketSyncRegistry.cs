using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using PDSI.MCP.TicketSync.Jobs;
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

			For<IVTigerConnection>()
				.LifecycleIs<TransientLifecycle>()
				.Use(ctx => GetMySqlConnection<IVTigerConnection>(ctx.GetInstance<IConfiguration>().GetConnectionString("vTiger")));

			For<IRactablesConnection>()
				.LifecycleIs<TransientLifecycle>()
				.Use(ctx => GetMySqlConnection<IRactablesConnection>(ctx.GetInstance<IConfiguration>().GetConnectionString("Racktables")));

			For<ISmarterTrackConnection>()
				.LifecycleIs<TransientLifecycle>()
				.Use(ctx => GetSqlServerConnection<ISmarterTrackConnection>(ctx.GetInstance<IConfiguration>().GetConnectionString("SmarterTrack")));
		}

		static T GetMySqlConnection<T>(String connectionString) where T: class, IDbConnection
		{
			var connection = new MySqlConnection(connectionString);
			connection.Open();
			return connection as T;
		}

		static T GetSqlServerConnection<T>(String connectionString) where T : class, IDbConnection
		{
			var connection = new SqlConnection(connectionString);
			connection.Open();
			return connection as T;
		}
	}
}
