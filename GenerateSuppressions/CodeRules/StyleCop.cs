namespace GenerateSuppressions.CodeRules;

internal static class StyleCop
{
    internal static List<CodeRule> Rules =
        [
            // Readability
            new CodeRule("SA1100", "A call to a member from an inherited class begins with base., and the local class does not contain an override or implementation of the member.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1101", "A call to an instance member of the local class or a base class is not prefixed with 'this.', within a C# code file.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1102", "A C# query clause does not begin on the same line as the previous clause, or on the next line.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1103", "The clauses within a C# query expression are not all placed on the same line, and each clause is not placed on its own line.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1104", "A clause within a C# query expression begins on the same line as the previous clause, when the previous clause spans across multiple lines.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1105", "A clause within a C# query expression spans across multiple lines, and does not begin on its own line.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1106", "The C# code contains an extra semicolon.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1107", "The C# code contains more than one statement on a single line.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1108", "A C# statement contains a comment between the declaration of the statement and the opening brace of the statement.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1109", "A C# statement contains a region tag between the declaration of the statement and the opening brace of the statement.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1110", "The opening parenthesis or bracket in a call to a C# method or indexer, or the declaration of a method or indexer, is not placed on the same line as the method or indexer name.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1111", "The closing parenthesis or bracket in a call to a C# method or indexer, or the declaration of a method or indexer, is not placed on the same line as the last parameter.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1112", "The closing parenthesis or bracket in a call to a C# method or indexer, or the declaration of a method or indexer, is not placed on the same line as the opening bracket when the element does not take any parameters.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1113", "A comma between two parameters in a call to a C# method or indexer, or in the declaration of a method or indexer, is not placed on the same line as the previous parameter.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1114", "The start of the parameter list for a method or indexer call or declaration does not begin on the same line as the opening bracket, or on the line after the opening bracket.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1115", "A parameter within a C# method or indexer call or declaration does not begin on the same line as the previous parameter, or on the next line.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1116", "The parameters to a C# method or indexer call or declaration span across multiple lines, but the first parameter does not start on the line after the opening bracket.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1117", "The parameters to a C# method or indexer call or declaration are not all on the same line or each on a separate line.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1118", "A parameter to a C# method or indexer, other than the first parameter, spans across multiple lines.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1120", "The C# comment does not contain any comment text.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1121", "The code uses one of the basic C# types, but does not use the built-in alias for the type.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1122", "The C# code includes an empty string, written as \"\".", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1123", "The C# code contains a region within the body of a code element.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1124", "The C# code contains a region.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1125", "The Nullable type has been defined not using the C# shorthand.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1126", "A call to a member is not prefixed with the 'this.', 'base.', 'object.' or 'typename.' prefix to indicate the intended method call, within a C# code file.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1127", "A generic constraint on a type or method declaration is on the same line as the declaration, within a C# code file.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1128", "A constructor initializer is on the same line as the constructor declaration, within a C# code file.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1129", "A value type was constructed using the syntax new T().", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1130", "An anonymous method was declared using the form delegate (parameters) { }, when a lambda expression would provide equivalent behavior with the syntax (parameters) => { }.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1131", "A comparison was made between a variable and a literal or constant value, and the variable appeared on the right-hand side of the expression.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1132", "Two or more fields were declared in the same field declaration syntax.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1133", "Two or more attributes appeared within the same set of square brackets.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1134", "An attribute is placed on the same line of code as another attribute or element.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1135", "A using directive is not qualified.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1136", "Multiple enum values are placed on the same line of code.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1137", "Two sibling elements which each start on their own line have different levels of indentation.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1139", "Use literal suffix notation instead of casting.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1141", "Use tuple syntax instead of the underlying ValueTuple implementation type.", "StyleCop.CSharp.ReadabilityRules"),
            new CodeRule("SA1142", "An element of a tuple was referenced by its metadata name when an element name is available.", "StyleCop.CSharp.ReadabilityRules"),

            // todo - add more rules
        ];
}
