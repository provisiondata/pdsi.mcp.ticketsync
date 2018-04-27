dotnet clean -c Release -r win7-x64
Remove-Item -Recurse -Force .\PDSI.MCP.TicketSync\bin\Release\
dotnet publish -c Release -r win7-x64