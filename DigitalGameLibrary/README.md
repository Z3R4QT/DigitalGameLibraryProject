# Digital Game Library - UI-Enhanced Template

This is a ready-to-open C# WinForms template targeting .NET 6.0 (net6.0-windows).
It includes:
- Main dashboard (MainForm) with quick stats
- GameForm (CRUD)
- UserForm (CRUD)
- OwnershipForm (assign games to users)
- UserReportForm (view & print user library)
- SQLite database initializer (creates `game_library.db` automatically)
- Repositories and simple models

How to open:
1. Install .NET 6 SDK (or newer) with Windows Forms support.
2. Open the folder in Visual Studio 2022+ or `dotnet` CLI.
3. Restore packages (`dotnet restore`) and run (`dotnet run`) or open the .sln in Visual Studio.

Note: The project uses `Microsoft.Data.Sqlite` package. If Visual Studio prompts to restore NuGet packages, allow it.
