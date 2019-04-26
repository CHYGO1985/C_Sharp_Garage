using System;

/*
 *
 * @jingjiejiang Apr 26, 2019 
 */
public class MinStack
{

    /** initialize your data structure here. */
    private int min;
    private Stack stack;

    public MinStack()
    {
        this.min = Int32.MaxValue;
        stack = new Stack();
    }

    public void Push(int x)
    {
        if (x <= min)
        {
            if (stack.Count != 0) stack.Push(min);
            min = x;
        }
        stack.Push(x);
    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            if ((int)stack.Pop() == min && stack.Count > 0) min = (int)stack.Pop();
        }

        if (stack.Count == 0) min = Int32.MaxValue;
    }

    public int Top()
    {
        return (int)stack.Peek();
    }

    public int GetMin()
    {
        return min;
    }
}

