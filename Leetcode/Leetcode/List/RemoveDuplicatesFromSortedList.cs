using System;

/*
 * 
 * @jingjiejiang Apr 19, 2019
 */ 
public class Class1
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode curHead = head;

        while (curHead != null && curHead.next != null) {

            ListNode shiftNode = curHead.next;

            while (shiftNode != null && shiftNode.val == curHead.val)
            {
                shiftNode = shiftNode.next;
            }

            curHead.next = shiftNode;
            curHead = curHead.next;
        }

        return head;
    }
}
