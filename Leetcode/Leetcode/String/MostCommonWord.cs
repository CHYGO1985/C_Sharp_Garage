using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
 * 
 * @jingjiejiang Apr 20, 2019
 */
public class MostCommonWord
{
    public string MostCommonWord1(string paragraph, string[] banned)
    {

        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string pattern = @"[!?',;.]";
        paragraph = Regex.Replace(paragraph, pattern, " ");
        string[] words = paragraph.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> banWords = new HashSet<string>();
        int max = 0;
        string res = "";

        foreach (string ban in banned)
        {
            banWords.Add(ban);
        }


        foreach (string word in words) {

            string curWord = word.ToLower();
            if (banWords.Contains(curWord)) continue;

            int curNum = wordCount.GetValueOrDefault(curWord, 0) + 1; 
            if (curNum > max)
            {
                res = curWord;
                max = curNum;
            }
            wordCount[curWord] = curNum;
        }

        return res;
    }
}
