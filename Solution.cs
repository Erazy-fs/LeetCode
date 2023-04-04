// Beginner's Guide
// 412. Fizz Buzz
public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> result = Enumerable.Range(1, n).Select(k => Convert.ToString(k)).ToList();

        for (int i = 3; i <= n; i += 3)
        {
            result[i - 1] = "Fizz";
        }

        for (int i = 5; i <= n; i += 5)
        {
            result[i - 1] = "Buzz";
        }

        for (int i = 15; i <= n; i += 15)
        {
            result[i - 1] = "FizzBuzz";
        }

        return result;
    }
}