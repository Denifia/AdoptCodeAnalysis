using static System.Runtime.InteropServices.JavaScript.JSType;

await Console.Out.WriteLineAsync("Paste in your build log and press Enter 3 times.");

var lines = new List<string?>();
do
{
    lines.Add(await Console.In.ReadLineAsync());
} while (lines.Count < 2 || !lines[^2..].TrueForAll(string.IsNullOrWhiteSpace));

await Console.Out.WriteLineAsync("Processing...");

var errorHook = ": error ";
var errors = lines
    .Where(x => x is not null)
    .Where(x => x.Contains(errorHook))
    .Select(x =>
    {
        var error = x.Substring(x.IndexOf(errorHook) + errorHook.Length);
        return new { Error = error, Rule = error.Substring(0, error.IndexOf(":")) };
    })
    .AsEnumerable();

var suppressions = errors
    .GroupBy(x => x.Rule)
    .Select(x => new { Rule = x.Key, Errors = x.ToArray(), Count = x.Count() })
    .OrderBy(x => x.Count)
    .Select(x => $"""[assembly: SuppressMessage("SonarRules", "{x.Rule}: e.g. {x.Errors[0].Error.Substring(x.Rule.Length + 2).Replace("\"", "\\\"")}", Justification = "Occurs {x.Count} times")]""")
    .ToArray();

foreach (var suppression in suppressions)
{
    await Console.Out.WriteLineAsync(suppression);
}

await Console.Out.WriteLineAsync();
await Console.Out.WriteLineAsync("Done.");