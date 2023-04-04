// Beginner's Guide
// 383. Ransom Note
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (magazine.Contains(ransomNote[i]))
            {
                magazine = magazine.Remove(magazine.IndexOf(ransomNote[i]), 1);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}