using System;

/**
 * 
 * @jingjiejiang April 11, 2019
 */
public class Class1
{
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {

        int x00 = rec1[0];
        int y00 = rec1[1];
        int x01 = rec1[2];
        int y01 = rec1[3];
        int x10 = rec2[0];
        int y10 = rec2[1];
        int x11 = rec2[2];
        int y11 = rec2[3];
        return x00 < x11 && x10 < x01 && y00 < y11 && y10 < y01;
    }
}
