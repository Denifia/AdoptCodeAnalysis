using GenerateSuppressions;
using GenerateSuppressions.CodeRules;
using System.Data;

var allRules = Sonar.Rules
                .Concat(StyleCop.Rules)
                .ToList();

await Console.Out.WriteLineAsync("Paste in your build log and press Enter a few times.");

var lines = new List<string?>();
do
{
    lines.Add(await Console.In.ReadLineAsync());
} while (lines.Count < 2 || !lines[^2..].TrueForAll(string.IsNullOrWhiteSpace));

var errorHook = ": error ";
var errors = lines
    .Where(x => x is not null)
    .Where(x => x.Contains(errorHook))
    .Select(x =>
    {
        var error = x.Substring(x.IndexOf(errorHook) + errorHook.Length);
        return new { ErrorMessage = error, ErrorCode = error.Substring(0, error.IndexOf(":")) };

    })
    .AsEnumerable();

var suppressions = errors
    .GroupBy(x => x.ErrorCode)
    .Select(x => new { Rule = AsCodeRule(x.First().ErrorCode), Count = x.Count() })
    .OrderBy(x => x.Rule.Category)
    .ThenBy(x => x.Count)
    .ToArray();

if (suppressions.Length == 0)
{
    await Console.Out.WriteLineAsync("No errors found.");
    await Console.Out.WriteLineAsync();
    await Console.Out.WriteLineAsync();
    return;
}

await Console.Out.WriteLineAsync("Copy the following into your GlobalSuppressions.cs");
await Console.Out.WriteLineAsync();
await Console.Out.WriteLineAsync();

await Console.Out.WriteLineAsync("""
    // This file is used by Code Analysis to maintain SuppressMessage
    // attributes that are applied to this project.
    // Project-level suppressions either have no target or are given
    // a specific target and scoped to a namespace, type, member, etc.

    using System.Diagnostics.CodeAnalysis;
    
    """);

foreach (var suppression in suppressions)
{
    await Console.Out.WriteLineAsync(FormatIntoAttribute(suppression.Rule, suppression.Count));
}

await Console.Out.WriteLineAsync();
await Console.Out.WriteLineAsync("Done.");

CodeRule AsCodeRule(string rule) 
    => allRules.Find(x => x.Code.Equals(rule, StringComparison.OrdinalIgnoreCase)) ?? new CodeRule(rule, "Unknown", "Unknown");

string FormatIntoAttribute(CodeRule rule, int count) 
    => $"""[assembly: SuppressMessage("{rule.Category}", "{rule.Code}: {rule.Message}", Justification = "Occurs {count} times")]""";