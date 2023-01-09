using System.Text;
namespace LeetCode.Problems.Medium;

/// <summary>
///   https://leetcode.com/problems/longest-substring-without-repeating-characters/
///   3. Longest Substring Without Repeating Characters
///   Level : Medium
/// </summary>
public sealed class LengthOfLongestSubstring3 : IProblem
{
    public void Execute()
    {
        // Console.WriteLine("abcabcbb: {0}", LengthOfLongestSubstring("abcabcbb"));
        // Console.WriteLine("bbbbb: {0}", LengthOfLongestSubstring("bbbbb"));
        // Console.WriteLine("pwwkew: {0}", LengthOfLongestSubstring("pwwkew"));
        // Console.WriteLine("pw: {0}", LengthOfLongestSubstring("pw"));
        Console.WriteLine("dvdf: {0}", LengthOfLongestSubstring("dvdf"));
    }

    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length <= 0) {
            return 0;
        }

        var prevWordLength = 1;
        var currentWord = "";

        for (int i = 0; i < s.Length; i++) {
            // Current symbol already exists in current word
            if (currentWord.Contains(s[i])) {
                if (currentWord.Length > prevWordLength) {
                    prevWordLength = currentWord.Length;
                }
                var index = currentWord.IndexOf(s[i]);
                currentWord = currentWord.Substring(index + 1) + s[i];
                continue;
            }

            currentWord += s[i];
        }

        if(currentWord.Length > prevWordLength) {
            prevWordLength = currentWord.Length;
        }

        return prevWordLength;
    }
}