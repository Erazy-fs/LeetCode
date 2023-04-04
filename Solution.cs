// Arrays 101
// 1089. Duplicate Zeros
public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int zerosCount = arr.Count(num => num == 0);

        for (int i = arr.Length - 1; i >= 0 && zerosCount > 0; i--)
        {
            if (arr[i] == 0)
            {
                zerosCount--;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }
            }
        }
    }
}