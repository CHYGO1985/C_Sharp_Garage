using System;

/**
 * 
 * @jingjiejiang April 10, 2019
 * 
 * 
 */
namespace Leetcode.List
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode dummy = head;

            while (l2 != null && l1 != null)
            {
                if (l1.val < l2.val)
                {
                    head.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    head.next = l2;
                    l2 = l2.next;
                }

                head = head.next;
            }

            head.next = l1 == null ? l2 : l1;

            return dummy.next;
        }
    }
}
