using System;

/*
 * 
 * @jingjiejiang Apr 24, 2019
 */ 
public class Class1
{
    public string AddBinary(string a, string b)
    {

        Stack aStack = new Stack();
        Stack bStack = new Stack();

        for (int aIdx = 0; aIdx < a.Length; aIdx++)
        {
            aStack.Push(a[aIdx] - '0');
        }

        for (int bIdx = 0; bIdx < b.Length; bIdx++)
        {
            bStack.Push(b[bIdx] - '0');
        }
        int carrier = 0;
        StringBuilder builder = new StringBuilder();

        while (aStack.Count > 0 && bStack.Count > 0)
        {
            int num = (int)aStack.Pop() + (int)bStack.Pop() + carrier;
            carrier = num >= 2 ? 1 : 0;
            builder.Insert(0, num % 2);
        }

        Stack availStack = aStack.Count > 0 ? aStack : bStack;
        while (availStack.Count > 0)
        {
            int num = (int)availStack.Pop() + carrier;
            carrier = num >= 2 ? 1 : 0;
            builder.Insert(0, num % 2);
        }

        if (carrier > 0) builder.Insert(0, carrier);

        return builder.ToString();
    }
}
