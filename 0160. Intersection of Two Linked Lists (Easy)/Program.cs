using System;

namespace _0160._Intersection_of_Two_Linked_Lists__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode headA = new ListNode(4);
            headA.next = new ListNode(1);
            headA.next.next = new ListNode(8);
            headA.next.next.next = new ListNode(4);
            headA.next.next.next.next = new ListNode(5);

            ListNode headB = new ListNode(5);
            headB.next = new ListNode(0);
            headB.next.next = new ListNode(1);
            headB.next.next.next = new ListNode(8);
            headB.next.next.next.next = new ListNode(4);
            headB.next.next.next.next.next = new ListNode(5);

            var result = GetIntersectionNode(headA, headB);

        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;

            int lenA = 0, lenB = 0;
            ListNode nodeA = headA, nodeB = headB;

            //計算headA、headB長度
            while (nodeA != null)
            {
                lenA++;
                nodeA = nodeA.next;
            }

            while (nodeB != null)
            {
                lenB++;
                nodeB = nodeB.next;
            }

            //計算長度差
            int diff = lenA - lenB;

            //重置nodeA、nodeB
            nodeA = headA; nodeB = headB;

            //對齊A、B比較起點
            if (diff > 0)
            {
                //A比B長，A先向前移動到對齊B的長度
                while (diff > 0)
                {
                    nodeA = nodeA.next;
                    diff--;
                }
            } 
            else
            {
                //B比A長，diff為負數
                while(diff < 0)
                {
                    nodeB = nodeB.next;
                    diff++;
                }
            }

            //開始比較A、B
            while(nodeA != null && nodeB != null)
            {
                if (nodeA != nodeB)
                {
                    nodeA = nodeA.next;
                    nodeB = nodeB.next;
                } else
                {
                    return nodeA;
                }
            }

            //都比完然後其中一個node為null則回傳null
            return null;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
