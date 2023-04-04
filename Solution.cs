// Beginner's Guide
// 1342. Number of Steps to Reduce a Number to Zero
public class Solution
{
    public int NumberOfSteps(int num)
    {
        int count = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num = num >> 1;
            }
            else
            {
                num = num & 1048574;
            }
            count++;
        }

        return count;
    }
}