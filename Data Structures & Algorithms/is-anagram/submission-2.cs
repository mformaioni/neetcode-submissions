public class Solution {
   public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;
    int[] alphabetCount = new int[27]; //sin la ñ son 26
    for (int i = 0; i < s.Length; i++)
    {
        alphabetCount[s[i] - 'a']++;
        alphabetCount[t[i] - 'a']--;
    }
    foreach (var letterCount in alphabetCount)
    {
        if(letterCount != 0) return false;
    }
    return true;
}
}
