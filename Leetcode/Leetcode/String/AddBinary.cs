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

        for (int aIdx = 0; aIdx < a.Length; aIdx ++)
        {
            aStack.Push(Int32.Parse(a[aIdx]));
        }

        for (int bIdx = 0; bIx < b.Length; bIdx ++)
        {
            bStack.Push(Int32.Parse(b[bIdx]));
        }

        int carrier = 0;
        StringBuilder builder = new StringBuilder();

        while (aStack.Count >0 && bStack.Count > 0)
        {
            int num = aStack.Pop() + bStack.Pop() + carrier;
            carrier = num >= 2 ? 1 : 0;
            builder.Insert(0, num % 2);
        }

        Stack availStack = aStack.Count > 0 ? aStack : bStack;
        while (availStack.Count > 0)
        {
            int num = availStack.Pop() + carrier;
            carrier = num >= 2 ? 1 : 0;
            builder.Insert(0, num % 2);
        }

        return builder.toString();
    }
}
