// Arrays 101
// 283. Move Zeroes
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int writerIndex = 0;
        int zerosCount = 0;

        for (int readerIndex = 0; readerIndex < nums.Length; readerIndex++)
        {
            if (nums[readerIndex] == 0)
            {
                zerosCount++;
            }
            else
            {
                nums[writerIndex] = nums[readerIndex];
                writerIndex++;
            }
        }

        for (int i = writerIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}