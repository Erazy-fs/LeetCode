// Arrays 101
// 1299. Replace Elements with Greatest Element on Right Side
public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int borderIndex = 0;

        while (borderIndex < arr.Length - 1)
        {
            int maxVal = arr[(borderIndex + 1)..].Max();
            int newBorderIndex = Array.IndexOf(arr[(borderIndex + 1)..], maxVal) + borderIndex + 1;

            for (int i = borderIndex; i < newBorderIndex; i++)
            {
                arr[i] = maxVal;
            }
            borderIndex = newBorderIndex;
        }

        arr[arr.Length - 1] = -1;

        return arr;
    }
}