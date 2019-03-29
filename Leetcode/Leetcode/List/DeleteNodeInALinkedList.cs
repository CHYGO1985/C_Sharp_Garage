using System;

/**
 * 
 * @jingjiejiang Mar 30, 2019
 * 
 */
namespace Leetcode.List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) => this.val = x;
    }

    public class DeleteNode
    {
        public void DeleteNode1(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
