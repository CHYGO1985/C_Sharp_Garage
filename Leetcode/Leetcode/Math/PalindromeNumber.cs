using System; 

/*
 * @jingjiejiang Apr 18, 2019
 */ 
public class Class1
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x < 10) return true; // 0 return true
        if (x % 10 == 0) return false;

        int oldNum = x;
        int newNum = x % 10;
        x /= 10;

        while (x > 0)
        {
            newNum = newNum * 10 + x % 10;
            x /= 10;
        }

        return newNum == oldNum ? true : false;
    }
}
