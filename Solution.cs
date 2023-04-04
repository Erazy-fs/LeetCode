// Beginner's Guide
// 383. Ransom Note
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> magDict = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            magDict[magazine[i]] = magDict.GetValueOrDefault(magazine[i], 0) + 1;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            int count = magDict.GetValueOrDefault(ransomNote[i], 0);

            if (count == 0)
            {
                return false;
            }
            else
            {
                magDict[ransomNote[i]] = --count;
            }
        }

        return true;
    }
}