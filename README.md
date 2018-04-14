# pdsi.mcp.ticketsync
Syncs SmarterTrack with vTiger and Racktables for SOC 2 compliance

## Command Line Options

| Option        | Description
|---------------|------------
| `--list-jobs` | Lists the configured jobs and their state, then exits.

## Configuration

TicketSync looks for `MCP_ENVIRONMENT` in the system environment variables.  If nothing is found it defaults to `Production`.  Whichever mode it is in will be logged at runtime.  The only pre-defined mode is `Production`, however other common sense modes could be `Staging`, `Development`, etc.

The basic configuration is stored in `appsettings.json` *(required)*.  Additional settings are stored in `appsettings.<MCP_ENVIRONMENT>.json` *(optional)* which will override anything in `appsettings.json`.  The best use for this is to keep passwords and other sensitive information out of Source Control by only checking in `appsettings.json` and explicity ignoring `appsettings.development.json`, etc.

### Jobs

TicketSync runs a series of Jobs.  You may want to enable/disable them individually from time to time.  This can be done in the `TicketSync` section.
```json
"TicketSync": {
  "Jobs": [
    { "Name": "UpdateVTigerAccountsInSmarterTrack", "Enabled": false },
    { "Name": "UpdateRacktablesAssetsInSmarterTrack", "Enabled": false },
    { "Name": "GenerateSmarterTrackCommentLinks", "Enabled": true }
  ]
}
```

To see which jobs are available use `--list-jobs` on the CLI.  I don't think the names are case sensitive, but they might be.

### SmarterTrack

| Key | O/R | Description
|-----|-----|------------
| `EndpointAddress`      | *required* | The URL of the SmarterTrack API.
| `AuthUserName`         | *required* | Valid SmarterTrack employee. Any groups it has not been added to will not be scanned for Account/Asset tags. Sadly, this account uses up one of the licensing slots.
| `AuthPassword`         | *required* | Valid password for `AuthUserName`
| `PdsiMcpUserId`        | *required* | The SmarterTrack database primary key of the employee specified in `AuthUserName`.
| `AssetCustomFieldId`   | *required* | The SmarterTrack database primary key of the RackTables Asset custom field.
| `AccountCustomFieldId` | *required* | The SmarterTrack database primary key of the vTiger Account custom field.
| `AccountUrlTemplate`   | *required* | Should be something like `http://support.provisiondata.net/vtigercrm/index.php?module=Accounts&action=DetailView&record={{AccountId}}`. `{{AccountId}}` will be replaced with the key (if present) in the vTiger Account tag.
| `AssetUrlTemplate`     | *required* | Should be something like `http://10.248.41.11/racktables/index.php?page=object&object_id={{AssetId}}`. `{{AssetId}}` will be replaced with the key (if present) in the RackTables Asset tag.
| `GenerateHtmlComments` | *optional* | Self explanatory.  Currently SmarterTrack will accept HTML comments but a bug prevents them from being displayed correctly so in the mean time we generate TEXT comments.  If they ever get the bug fixed then all you have to do is flip this to <em>true</em> and all the comments will be updated. See `TicketScanLimit` if you feel like it's not working.   Default <em>false</em>
| `MessageType`          | *optional* | Indicates the type of SmarterTrack comment that should be generated.  Currently has no effect because SmarterTrack has a bug. Default: <em>general</em>
| `TicketScanLimit`      | *optional* | The number of tickets that should be scanned.  The SmarterTrack API is pretty dumb and returns (almost) all the tickets.  This setting hellps keep the execution duration manageable. Default: <em>500</em>

### Database Connection Strings
| Key | O/R | Description
|-----|--------|------------
| `SmarterTrack` | *required* | Eg. `Data Source=127.0.0.1;Initial Catalog=SmarterTrack;Persist Security Info=True;User Id=<userid>;Password=<password>;MultipleActiveResultSets=true;`
| `vTiger`       | *required* | Eg. `host=127.0.0.1;port=3306;user id=<userid>;password=<password>;database=vtigercrm521;`
| `RackTables`   | *required* | Eg. `host=127.0.0.1;port=3306;user id=<userid>;password=<password>;database=racktables;`

### Serilog Configuration

TicketSync relies on [Serilog.Settings.Configuration](https://github.com/serilog/serilog-settings-configuration) to allow configuration of the logging system. A comprehensive explanation is available at the project home page.

> Note: In order to use a Sink it must be present in the same directory as TicketSync.  It is not necessary to recompile the application to use [additional sinks](https://github.com/serilog/serilog/wiki/Provided-Sinks).

We may as well start with an example. 

```json
"Serilog": {
  "Using": [ "Serilog.Sinks.Console", "Serilog.Sinks.File", "Serilog.Sinks.Graylog" ],
  "MinimumLevel": {
    "Default": "Verbose"
  },
  "WriteTo": [
    {
      "Name": "Console",
      "Args": {
        "restrictedToMinimumLevel": "Debug"
      }
    },
    {
      "Name": "File",
      "Args": {
        "path": "TicketSync.Log",
        "rollingInterval": "Day",
        "retainedFileCountLimit": 90,
        "restrictedToMinimumLevel": "Verbose"
      }
    },
    {
      "Name": "Graylog",
      "Args": {
        "hostnameOrAddress": "graylog.pdsint.net",
        "port": "12201",
        "transportType": "Udp",
        "minimumLogEventLevel": "Information"
      }
    }
  ]
}
```

In the above example the following has been configured:

* The `MinimumLevel` is set to `Verbose`.  This means that all [log events](https://github.com/serilog/serilog/wiki/Configuration-Basics#minimum-level) will be passed through the logging pipeline.  If you don't want that, then specify a higher logging level like `Information`. That way lower events will not be passed through to the configured sinks. If no `MinimumLevel` is specified, then it defaults to `Information`.
* Logging Sinks:
  * **[Console](https://github.com/serilog/serilog-sinks-console):** Log events of `Debug`, `Information`, `Warning`, `Error` and `Fatal` will be written to *stdout*.
  * **[File](https://github.com/serilog/serilog-sinks-file):** Log events of `Verbose`, `Debug`, `Information`, `Warning`, `Error` and `Fatal` will be written to a log file.
    * *path* This defines the path the log files will be written to.
    * *rollingInterval* Determines how often a new log file will be started.
    * *retainedFileCountLimit = 90*  There will be one log file per day to a maximum of 90 log files.  Files older than that will be automatically removed. Default value is `31`
  * **[Graylog](https://github.com/whir1/serilog-sinks-graylog):** Log events of `Information`, `Warning`, `Error` and `Fatal` to [Graylog](https://www.graylog.org/)

## Building from source

To do a complete build execute the following from the project root:

```bash
dotnet publish -c Release -r win7-x64
```

## Deployment

If the build completed successfully the files will be somewhere similar to:

```bash
./PDSI.MCP.TicketSync/bin/Release/netcoreapp2.0/win7-x64/publish
```

You can leave them there if you like or copy them elsewhere.  Sorry that there's so many. Take it up with Microsoft.

To run on Windows it's just:

```bash
TicketSync.exe
```
> Note: If you run TicketSync as a Scheduled Task in Windows the Window account it runs as must have the `Log on as a batch job` Local Security Policy.

To run on Linux:

```bash
dotnet ./ticketsync.dll
```
