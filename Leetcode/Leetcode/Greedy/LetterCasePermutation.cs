using System;
using System.Collections.Generic;

/*
 * 
 * @jingjiejiang Mar 27, 2019
 * 
 */
namespace Leetcode.Greedy
{
    public class LetterCasePermutation
    {
        public IList<string> LetterCasePermutation1(string S)
        {
            char[] arr = S.ToCharArray();
            List<string> list = new List<string>();
            dfs(list, 0, arr);

            return list;
        }

        private void dfs(List<string> list, int index, char[] arr)
        {
            if (index >= arr.Length)
            {
                list.Add(new string(arr));
                return ;
            }

            if (Char.IsDigit(arr[index]))
            {
                dfs(list, index + 1, arr);
            }
            else
            {
                dfs(list, index + 1, arr);
                arr[index] = Char.IsLower(arr[index]) ? Char.ToUpper(arr[index]) : Char.ToLower(arr[index]);
                dfs(list, index + 1, arr);
            }
        }
    }
}
