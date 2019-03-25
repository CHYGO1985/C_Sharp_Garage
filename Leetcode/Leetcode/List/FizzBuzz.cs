using System;
using System.Collections.Generic;

namespace Leetcode.List
{
    public class FizzBuzz
    {
        public IList<string> FizzBuzz1(int n)
        {
            List<string> list = new List<string>();

            List<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }
    }
}
}
