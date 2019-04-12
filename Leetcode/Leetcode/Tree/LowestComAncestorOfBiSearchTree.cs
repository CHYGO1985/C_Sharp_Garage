using System;

/*
 * 
 * @jingjiejiang April 12, 2019 
 */
public class Class1
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null) return null;

        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);

        if ((root.val == p.val || root.val == q.val) || (left != null && right != null))
        {
            return root;
        }
        else
        {
            return left == null ? right : left;
        }
    }
}
