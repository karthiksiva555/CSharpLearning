namespace CSharpEleven;

public static class RawStringLiterals
{
    public static void Run()
    {
        RunStringLiterals();
        RunStringInterpolation();
    }
    
    /// <summary>
    /// string can contain arbitrary text including whitespace, new lines, embedded quotes and other special characters without requiring escape sequences
    /// The string must contain at least three double quotes
    /// </summary>
    private static void RunStringLiterals()
    {
        const string longMessage = """
            New feature introduced in 
            C# 11. Now string can be in any lines
            but with three double quotes
            quoted text "is also allowed"
            """;

        Console.WriteLine(longMessage);
    }

    /// <summary>
    /// Can include braces in the output string. Multiple $ characters denote how many braces to start and end interpolation
    /// In below example, $$ indicate {{}} is used for interpolation. The extra { and } is included in output string. 
    /// </summary>
    private static void RunStringInterpolation()
    {
        const double longitude = 12.50;
        const double latitude = 80.56;
        var location = $$"""
            The location of car 
            is {{{longitude}}, {{latitude}}}
            """;
        Console.WriteLine(location);
    }
}