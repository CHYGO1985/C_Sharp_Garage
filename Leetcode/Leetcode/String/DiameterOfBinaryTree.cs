using System;

/**
 * 
 * @jingjiejiang April 10, 2019
 * 
 */
public class Class1
{
    private int sum = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {

        if (root == null) return 0;

        helper(root);

        return sum - 1;
    }

    private int helper(TreeNode root)
    {

        if (root == null) return 0;

        int left = helper(root.left);
        int right = helper(root.right);

        sum = Math.Max(sum, left + right + 1);

        return Math.Max(left, right) + 1;
    }
}
