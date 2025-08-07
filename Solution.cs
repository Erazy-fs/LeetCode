// Beginner's Guide
// 412. Fizz Buzz
public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        return Enumerable.Range(1, n).Select(ProcessNum).ToList();
    }

    public string ProcessNum(int n)
    {
        return n switch
        {
            int num when num % 3 == 0 && num % 5 == 0 => "FizzBuzz",
            int num when num % 3 == 0 => "Fizz",
            int num when num % 5 == 0 => "Buzz",
            _ => n.ToString(),
        };
    }
}
