using System.Collections.Immutable;

public static class Pangram
{
    private static readonly ImmutableHashSet<char> alphabet = ImmutableHashSet<char>.Empty.Union("abcdefghijklmnopqrstuvwxyz");
    public static bool IsPangram(string input) => alphabet.Intersect(input.ToLower()).Count == alphabet.Count;
}