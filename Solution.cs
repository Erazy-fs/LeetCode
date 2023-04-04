// Arrays 101
// 485. Max Consecutive Ones
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        return nums.Length < 3 ? nums.Count(x => x == 1) : Enumerable.Range(1, nums.Length - 1).Select(x => nums[x] == 1 ? nums[x] = nums[x - 1] + 1 : nums[x] = nums[x]).Max();
    }
}