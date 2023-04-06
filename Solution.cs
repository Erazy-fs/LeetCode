// Arrays 101
// 905. Sort Array By Parity
public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int endPointer = nums.Length - 1;

        for (int i = 0; i < endPointer; i++)
        {
            while (nums[endPointer] % 2 != 0 && endPointer > i)
            {
                endPointer--;
            }

            if (nums[i] % 2 != 0)
            {
                (nums[i], nums[endPointer]) = (nums[endPointer], nums[i]);
                endPointer--;
            }
        }

        return nums;
    }
}