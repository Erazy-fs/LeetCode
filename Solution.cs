// Arrays 101
// 26. Remove Duplicates from Sorted Array
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int shift = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                shift++;
            }
            else
            {
                nums[i - shift] = nums[i];
            }
        }

        return nums.Length - shift;
    }
}