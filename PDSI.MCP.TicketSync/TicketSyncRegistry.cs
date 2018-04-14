using System;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
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
                _.AssembliesAndExecutablesFromApplicationBaseDirectory();
				_.WithDefaultConventions();
                _.LookForRegistries();
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

		}

		static IDbConnection GetMySqlConnection(String connectionString)
		{
			var connection = new MySqlConnection(connectionString);
			connection.Open();
			return connection;
		}
	}
}
