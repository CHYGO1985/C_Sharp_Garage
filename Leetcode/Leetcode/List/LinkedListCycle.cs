using System;

/*
 * @jingjiejiang Apr 27, 2019
 */ 
namespace Leetcode.List
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            if (head.next == head) return true;

            ListNode fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                if (head == fast)
                {
                    return true;
                }
                head = head.next;
            }

            return false;
        }
    }
}
