using System;

/**
 * 
 * @jingjiejiang Apr 5, 2019
 */
namespace Leetcode.String
{
    public class RotateString
    {
        public bool RotateString(string A, string B)
        {
            if (A.Length != B.Length) return false;
            if (A.Equals(B)) return true;

            for (int idx = 0; idx < A.Length; idx ++)
            {
                string tmp = A.Substring(idx);

                if (B.IndexOf(tmp, StringComparison.Ordinal) == 0 &&
                    A.Substring(0, idx).Equals(B.Substring(tmp.Length, idx)))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
