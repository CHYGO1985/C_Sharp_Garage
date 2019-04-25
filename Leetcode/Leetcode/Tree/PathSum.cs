using System;

/*
 * 
 * @jingjiejiang Apr 25, 2019
 */ 
public class Class1
{
    public bool HasPathSum(TreeNode root, int sum)
    {
        if (root == null) return false;

        sum = sum - root.val;

        if (root.left == null && root.right == null)
        {
            return sum == 0 ? true : false;
        }

        return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
    }
}
