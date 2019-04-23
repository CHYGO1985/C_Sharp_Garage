using System;

/*
 * 
 * @jingjiejiang Apr 23, 2019
 */ 
public class Class1
{
    public bool IsBalanced(TreeNode root)
    {
        bool[] res = new bool[1];
        res[0] = true;

        check(root, res);

        return res[0];
    }

    private int check(TreeNode root, bool[] res)
    {
        if (root == null) return 0;

        int left = check(root.left, res);
        int right = check(root.right, res);

        if (Math.Abs(left - right) > 1) res[0] = false;

        return Math.Max(left, right) + 1;
    }
}
