// Arrays 101
// 485. Max Consecutive Ones
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int currentCount = 0;
        int maxCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 0;
            }
        }

        return maxCount;
    }
}