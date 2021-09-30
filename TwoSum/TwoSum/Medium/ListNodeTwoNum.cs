using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class ListNodeTwoNum
    {
        public ListNodeTwoNum()
        {
            //var l1 = new ListNode() { val = 2, next = new ListNode() { val = 4, next = new ListNode() { val = 3 } } };
            //var l2 = new ListNode() { val = 5, next = new ListNode() { val = 6, next = new ListNode() { val = 4 } } };
            var l1 = new ListNode() { val = 0 };
            var l2 = new ListNode() { val = 0 };
            AddTwoNumbers(l1, l2);
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var l3 = new ListNode();
            RecursiveAdd(l1, l2, l3, 0);
            return l3;
        }
        private void RecursiveAdd(ListNode l1, ListNode l2, ListNode l3, int carryForward)
        {
            int total = ((l1?.val) ?? 0) + ((l2?.val) ?? 0);
            total += carryForward;
            carryForward = (total - (total % 10)) / 10;

            l3.val = total % 10;
            if (l1?.next == null && l2?.next == null)
            {
                if (carryForward != 0)
                    l3.next = new ListNode() { val = carryForward };
                return;
            }
            l3.next = new ListNode();
            RecursiveAdd(l1?.next, l2?.next, l3?.next, carryForward);
        }
    }

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

    }
}
