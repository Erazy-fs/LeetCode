// Beginner's Guide
// 412. Fizz Buzz
public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        string[] result = new string[n];

        for (int i = 1; i <= n; i++)
        {
            string subStr = "";
            if (i % 3 == 0)
            {
                subStr += "Fizz";
            }
            if (i % 5 == 0)
            {
                subStr += "Buzz";
            }
            if (subStr == "")
            {
                subStr = Convert.ToString(i);
            }

            result[i - 1] = subStr;
        }

        return result;
    }
}