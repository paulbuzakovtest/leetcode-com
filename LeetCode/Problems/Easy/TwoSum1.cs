namespace LeetCode.Problems.Easy;

/// <summary>
///   https://leetcode.com/problems/two-sum/
///   1. Two Sum
///   Level : Easy
/// </summary>
public sealed class TwoSum1 : IProblem
{
    public void Execute()
    {
        Execute(new [ ] { 2, 7, 11, 15}, 9);
        Execute(new [ ] { 3, 2, 4}, 6);
        Execute(new [ ] { 3, 3}, 6);
        Execute(new [ ] { 3, 2, 3}, 6);
    }

    public void Execute(int[] nums, int target)
    {
        var result = TwoSum(nums, target);

        foreach(var index in result) {
            Console.WriteLine(index);
        }
    }

    public int[] TwoSum(int[] nums, int target)
    {
        if (nums.Length < 2) {
            return Array.Empty<int>();
        }

        for (int j = 0; j < nums.Length; j ++) {
            for (int i = 0; i < nums.Length; i++) {
                if (i == j) {
                    continue;
                }

                if (nums[j] + nums[i] == target) {
                    return new []{j, i};
                }
            }
        }

        return Array.Empty<int>();
    }
}
