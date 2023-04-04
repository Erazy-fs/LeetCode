// Arrays 101
// 1295. Find Numbers with Even Number of Digits
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Count(num => (num.ToString().Length & 1) == 0);
    }
}