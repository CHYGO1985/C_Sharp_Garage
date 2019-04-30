using System;

/*
 * @jingjiejiang Apr 30, 2019
 * 
 */ 
public class Class1
{
    public bool IsValid(string s)
    {
        if (s == null) return true;

        Stack charsStack = new Stack();

        foreach (char character in s)
        {
            if (character == '(' || character == '[' || character == '{')
            {
                charsStack.Push(character);
            }
            else
            {
                if (charsStack.Count == 0) return false;
                StackFiller(charsStack, character);
            }
        }

        return charsStack.Count == 0 ? true : false;
    }

    private void StackFiller(Stack stack, char character)
    {

        switch (character)
        {
            case ')' :
                if ((char)stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(character);
                }
                break;
            case '}':
                if ((char)stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(character);
                }
                break;
            case ']':
                if ((char)stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(character);
                }
                break;
            default:
                break;
        }
    }
}
