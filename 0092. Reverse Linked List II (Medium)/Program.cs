using System;
using System.Collections.Generic;

namespace _0092._Reverse_Linked_List_II__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);
            var result = ReverseBetween(node, 3, 4);
        }

        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right) return head;

            Stack<ListNode> st = new Stack<ListNode>();
            ListNode leftNode = null;
            ListNode node = head;

            if (left != 1)
            {
                for (int i = 1; i < left - 1; ++i) 
                    node = node.next;

                leftNode = node;
                node = node.next; // position m
            }

            for (int i = left; i <= right; ++i)
            {
                st.Push(node);
                node = node.next;
            }

            ListNode l1 = st.Pop(), l2 = null;

            if (left == 1)
                head = l1;
            else
                leftNode.next = l1;

            while (st.Count != 0)
            {
                l2 = st.Pop();
                l1.next = l2;
                l1 = l2;
            }
            l1.next = node;

            return head;
        }


        public class ListNode
        {
            public int val;
            public ListNode next = null;
            public ListNode(int x) { val = x; }
        }
    }
}
