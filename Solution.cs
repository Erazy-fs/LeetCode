// Arrays 101
// 977. Squares of a Sorted Array
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        nums = nums.Select(num => num * num).ToArray();
        Array.Sort(nums);
        return nums;
    }
}