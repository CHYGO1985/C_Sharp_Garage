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

        if (root.left == null) return HasPathSum(root.right, sum);
        if (root.right == null) return HasPathSum(root.left, sum);

        return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
    }
}
