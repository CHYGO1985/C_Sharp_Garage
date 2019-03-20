using System;
namespace Leetcode.String
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int head = 0, rear = s.Length - 1;
            while(head < rear)
            {
                char tmp = s[head];
                s[head ++] = s[rear];
                s[rear --] = tmp;
            }
        }
    }
}
