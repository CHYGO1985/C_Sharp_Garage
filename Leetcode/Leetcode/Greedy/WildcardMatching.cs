using System;
namespace Leetcode
{
    public class WildcardMatching
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] matches = new bool[p.Length + 1, s.Length + 1];
            matches[0, 0] = true;
            for (int row = 1; row < matches.GetLength(0); row ++)
            {
                matches[row, 0] = p[row - 1] == '*' ? matches[row - 1, 0] : false; 
            }

            for (int row = 1; row < matches.GetLength(0); row ++)
            {
                char rowChar = p[row - 1];
                for (int col = 1; col < matches.GetLength(1); col ++)
                {
                    char colChar = s[col - 1];
                    if (rowChar == colChar || rowChar == '?')
                    {
                        matches[row, col] = matches[row - 1, col - 1];
                    } else if (rowChar == '*') {
                        matches[row, col] = matches[row - 1, col]
                        || matches[row, col - 1] || matches[row - 1, col - 1];
                    }
                    else
                    {
                        matches[row, col] = false;
                    }
                }
            }

            return matches[p.Length, s.Length];
        }
    }
}
