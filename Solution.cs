// Arrays 101
// 27. Remove Element
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int shift = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
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