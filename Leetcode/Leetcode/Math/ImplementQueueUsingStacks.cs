using System;

/*
 * @jingjiejiang Apr 18, 2019
 * 
 */
public class Class1
{
    private Stack<int> stack;

    /** Initialize your data structure here. */
    public MyQueue()
    {
        stack = new Stack<int>();
    }

    /** Push element x to the back of queue. */
    public void Push(int x)
    {
        stack.Push(x);
    }

    private Stack<int> getInvertStack()
    {
        Stack<int> cache = new Stack<int>();

        while (stack.Count != 0)
        {
            cache.Push(stack.Pop());
        }

        return cache;
    }

    /** Removes the element from in front of queue and returns that element. */
    public int Pop()
    {
        Stack<int> cache = getInvertStack();

        int res = cache.Pop();

        while (cache.Count != 0)
        {
            stack.Push(cache.Pop());
        }

        return res;
    }

    /** Get the front element. */
    public int Peek()
    {
        Stack<int> cache = getInvertStack();

        int res = cache.Peek();

        while (cache.Count != 0)
        {
            stack.Push(cache.Pop());
        }

        return res;
    }

    /** Returns whether the queue is empty. */
    public bool Empty()
    {
        return stack.Count == 0;
    }
}
