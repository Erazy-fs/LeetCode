// Arrays 101
// 414. Third Maximum Number
public class Solution
{
    public int ThirdMax(int[] nums)
    {
        Array.Sort(nums);
        nums = nums.Distinct().ToArray();
        return nums.Length < 3 ? nums[nums.Length - 1] : nums[nums.Length - 3];
    }
}