using System;

/*
 * 
 * @jingjiejiang Apr 13, 2019 
 */
namespace Leetcode.Tree
{
    public class SecMinNodeInBinTree
    {
        bool isChanged = false;
        public int FindSecondMinimumValue(TreeNode root)
        {

            int[] range = new int[] { root.val, Int32.MaxValue };
            findValue(root, range);
            return isChanged ? range[1] : -1;
        }

        private void findValue(TreeNode root, int[] range)
        {

            if (root == null) return;

            if (root.val > range[0] && root.val <= range[1])
            {
                range[1] = root.val;
                isChanged = true;
            }


            findValue(root.left, range);
            findValue(root.right, range);
        }
    }
}
