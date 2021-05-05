using System;

namespace _0148.Sort_List__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 2, 1, 3 };
            ListNode head = new ListNode(4);
            head.next = new ListNode(2);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            ListNode sortList = SortList(head);
            Console.WriteLine(sortList.ToString());
        }

        public static ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            // 使用分治法(divide-and-conquer)，找 linked list 中間節點
            ListNode fast = head;
            ListNode slow = head;

            //使用slow跟fast兩個pointer的方式，讓slow一次走一格，
            //而fast一次走兩格，直到fast到底的時候(遇到NIL)就代表slow應該走到一半了
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //位於中間節點的下一個節點，從它那裡將一個 linked list 斷開
            ListNode midNext = slow.next;

            //從中間切開，分割成兩個 linked list
            slow.next = null;

            ListNode listNodeLeft = SortList(head);
            ListNode listNodeRight = SortList(midNext);

            //將兩個排好序的 linked list 合併
            return MergeOfTwoSortListNode(listNodeLeft, listNodeRight);
        }

        public static ListNode MergeOfTwoSortListNode(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            if (l1.val < l2.val)
            {
                l1.next = MergeOfTwoSortListNode(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeOfTwoSortListNode(l1, l2.next);
                return l2;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
