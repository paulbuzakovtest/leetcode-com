using BenchmarkDotNet.Attributes;

namespace LeetCode.Problems;

/// <summary>
///   https://leetcode.com/problems/is-subsequence/
///   392. Is Subsequence
///   Level : Easy
/// </summary>
public class IsSubsequence392 : IProblem
{
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
    
    public bool IsSubsequenceWithVar(string s, string t)
    {
        if (string.IsNullOrWhiteSpace(s))
            return true;

        var result = 0;
        var i = 0;
        for (var j = 0; j < s.Length; i++)
        {
            if (i >= t.Length) return false;

            if (t[i] != s[j]) continue;
            j++;
            result++;

            if (result == s.Length) return true;
        }

        return false;
    }
    
    public bool IsSubsequenceWithSpan(ReadOnlySpan<char> s, ReadOnlySpan<char> t)
    {
        var result = 0;
        var i = 0;
        for (var j = 0; j < s.Length; i++)
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