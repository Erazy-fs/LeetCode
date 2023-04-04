// Arrays 101
// 941. Valid Mountain Array
public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        int index = 2;

        if (arr.Length < 3 || arr[0] >= arr[1])
        {
            return false;
        }

        while (index < arr.Length - 1)
        {
            if (arr[index - 1] == arr[index])
            {
                return false;
            }
            else if (arr[index - 1] > arr[index])
            {
                break;
            }
            index++;
        }

        while (index < arr.Length)
        {
            if (arr[index - 1] <= arr[index])
            {
                return false;
            }
            index++;
        }

        return true;
    }
}