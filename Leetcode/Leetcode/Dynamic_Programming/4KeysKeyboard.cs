using System;
namespace Leetcode
{
    public class _KeysKeyboard
    {
        public int MaxA(int N)
        {
            int[] res = new int[N + 1];
            res[0] = 0;

            for (int idx = 0; idx < N; idx++)
            {
                if (idx <= 6)
                {
                    res[idx] = idx;
                }
                else
                {
                    res[idx] = Math.Max(res[idx - 3] * 2, Math.Max(res[idx - 4] * 3,
                        Math.Max(res[idx - 5] * 4, idx)));
                }
            }

            return res[N];
        }
    }
}
