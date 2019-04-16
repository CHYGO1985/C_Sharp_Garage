using System;

/*
 *
 * @jingjiejiang Apr 16, 2019
 */
public class Class1
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;

        return checkSym(root.left, root.right);
    }

    private bool checkSym(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
        {
            return true;
        }

        if (root1 == null || root2 == null)
        {
            return false;
        }

        return checkSym(root1.left, root2.right) & checkSym(root1.right, root2.left);
    }
}
