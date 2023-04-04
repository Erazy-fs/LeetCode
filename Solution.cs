﻿// Beginner's Guide
// 383. Ransom Note
public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> rnDict = new Dictionary<char, int>();
        Dictionary<char, int> magDict = new Dictionary<char, int>();

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (rnDict.ContainsKey(ransomNote[i]))
            {
                rnDict[ransomNote[i]]++;
            }
            else
            {
                rnDict.Add(ransomNote[i], 1);
            }
        }

        for (int i = 0; i < magazine.Length; i++)
        {
            if (magDict.ContainsKey(magazine[i]))
            {
                magDict[magazine[i]]++;
            }
            else
            {
                magDict.Add(magazine[i], 1);
            }
        }

        foreach (var letter in rnDict)
        {
            if (magDict.ContainsKey(letter.Key) && magDict[letter.Key] >= letter.Value)
            {
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}