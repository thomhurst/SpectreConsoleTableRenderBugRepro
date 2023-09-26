// See https://aka.ms/new-console-template for more information

using Spectre.Console;

var table = new Table();

table.AddColumn("Module");
table.AddColumn("Duration");
table.AddColumn("Status");
table.AddColumn("Start");
table.AddColumn("End");
table.AddColumn(string.Empty);

for (var i = 0; i < 55; i++)
{
    table.AddRow(
        $"[cyan]{Guid.NewGuid():N}[/]",
        $"{Guid.NewGuid():N}",
        $"{Guid.NewGuid():N}",
        $"{Guid.NewGuid():N}",
        $"{Guid.NewGuid():N}",
        $"{Guid.NewGuid():N}");
            
    table.AddEmptyRow();
}

Console.WriteLine();
AnsiConsole.Write(table);
Console.WriteLine();