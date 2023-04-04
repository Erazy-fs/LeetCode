// Arrays 101
// 1089. Duplicate Zeros
public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int[] arrCopy = new int[arr.Length];
        Array.Copy(arr, arrCopy, arr.Length);
        int shift = 0;

        for (int i = 0; i + shift < arrCopy.Length; i++)
        {
            arr[i + shift] = arrCopy[i];

            if (arrCopy[i] == 0)
            {
                shift++;
                if (i + shift == arrCopy.Length)
                {
                    break;
                }
                arr[i + shift] = arrCopy[i];
            }
        }
    }
}