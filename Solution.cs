// Arrays 101
// 1295. Find Numbers with Even Number of Digits
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Select(x => x.ToString()).Where(x => (x.Length & 1) == 0).Count();
    }
}