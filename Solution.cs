// Arrays 101
// 485. Max Consecutive Ones
public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0;
        int currentCount = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                currentCount++;
            }
            else
            {
                currentCount = 0;
            }
            maxCount = Math.Max(currentCount, maxCount);
        }

        return maxCount;
    }
}