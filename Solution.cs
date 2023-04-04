// Arrays 101
// 1346. Check If N and Its Double Exist
public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        Array.Sort(arr);

        int i = 0;

        while (i < arr.Length && arr[i] * 2 <= arr[arr.Length - 1])
        {
            int numIndex = Array.FindIndex(arr, num => num == arr[i] * 2);

            if (numIndex != -1 && numIndex != i)
            {
                return true;
            }
            i++;
        }

        return false;
    }
}