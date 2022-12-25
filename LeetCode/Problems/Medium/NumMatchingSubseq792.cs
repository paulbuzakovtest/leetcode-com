namespace LeetCode.Problems.Medium;

/// <summary>
///   https://leetcode.com/problems/number-of-matching-subsequences/
///   792. Number of Matching Subsequences
///   Level : Medium
/// </summary>
public sealed class NumMatchingSubseq792 : IProblem
{
    public void Execute()
    {
        Console.WriteLine(NumMatchingSubseq("abcde", new[]{"a","bb","acd","ace"}));
    }

    public int NumMatchingSubseq(string s, string[] words)
    {
        var groups = new Dictionary<string, ushort>();
        foreach (var word in words)
        {
            if (!groups.ContainsKey(word))
                groups[word] = 0;
            groups[word] += 1;
        }

        foreach (var word in groups)
        {
            byte result = 0;
            for (ushort i = 0, j = 0; i < s.Length && j < word.Key.Length; i++)
            {
                if (word.Key[j] != s[i]) continue;
                result++;
                j++;
                if (result == word.Key.Length) break;
            }

            if (result != word.Key.Length) groups.Remove(word.Key);
        }

        return groups.Sum(a => a.Value);
    }
}