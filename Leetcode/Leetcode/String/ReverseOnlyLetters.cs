using System;
namespace Leetcode.String
{
    public class ReverseOnlyLetters
    {
        public string ReverseOnlyLetters1(string S)
        {
            var chars = S.ToCharArray();

            for (int head = 0, rear = S.Length - 1; head < rear; head ++, rear --)
            {
                while (head < rear && Char.IsLetter(chars[head]) == false) head ++;
                while (head < rear && char.IsLetter(chars[rear]) == false) rear --;

                if (head < rear)
                {
                    char tmp = chars[head];
                    chars[head] = chars[rear];
                    chars[rear] = tmp;
                }
            }

            return new string(chars);
        }
    }
}
