// Arrays 101
// 1051. Height Checker
public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int count = 0;
        int[] heightsSorted = new int[heights.Length];

        heights.CopyTo(heightsSorted, 0);
        Array.Sort(heightsSorted);

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != heightsSorted[i])
            {
                count++;
            }
        }

        return count;
    }
}