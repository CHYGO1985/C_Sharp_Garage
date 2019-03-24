using System;
namespace Leetcode.Tree
{
    public class TreeNode
    {

        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.val = val;
        }
    }

    public class TrimABinarySearchTree
    {

        public TreeNode TrimBST(TreeNode root, int L, int R)
        {

            if (root == null) return null;

            if (root.val < L)
            {
                return TrimBST(root.right, L, R);
            }
            else if (root.val > R)
            {
                return TrimBST(root.left, L, R);
            }

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);

            return root;

        }
    }
}
