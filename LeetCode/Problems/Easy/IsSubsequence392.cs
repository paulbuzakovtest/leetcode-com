namespace LeetCode.Problems.Easy;

/// <summary>
///   https://leetcode.com/problems/is-subsequence/
///   392. Is Subsequence
///   Level : Easy
/// </summary>
public sealed class IsSubsequence392 : IProblem
{
    public void Execute()
    {
        Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
    }

    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrWhiteSpace(s))
            return true;

        byte result = 0;
        ushort i = 0;
        for (byte j = 0; j < s.Length; i++)
        {
            if (i >= t.Length) return false;

            if (t[i] != s[j]) continue;
            j++;
            result++;

            if (result == s.Length) return true;
        }

        return false;
    }
}