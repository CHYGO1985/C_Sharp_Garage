using System;

/**
 * 
 * @jingjiejiang April 9, 2019
 * 
 * 
 */
namespace Leetcode.List
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            if (l2 != null)
            {
                if (l1.val < l2.val)
                {
                    l1 = l1.next;
                }
                else
                {
                    ListNode l1Next = l1.next;
                    ListNode l2Next = l2.next;
                    l1 = l2;
                    l1.next = l1Next;
                    l2 = l2Next;
                }

                return MergeTwoLists1(l1, l2);
            }

            return l1;
        }
    }
}
