using System;
using Leetcode.Tree;

/*
 * 
 * @jingjiejiang Apr 21, 2019
 */
namespace Leetcode
{
    public class SubtreeOfAnotherTree
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {

            if (t == null && s == null) return true;
            if (t == null || s == null) return false;

            bool res = false;

            if (s.val == t.val)
            {
                res = check(s, t);
            }

            return res || IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        private bool check(TreeNode s, TreeNode t)
        {

            if (s == null && t == null) return true;
            if (s == null || t == null) return false;
            if (s.val != t.val) return false;

            return check(s.left, t.left) && check(s.right, t.right);
        }
    }
}
