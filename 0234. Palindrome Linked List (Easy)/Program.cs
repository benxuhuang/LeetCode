using System;

namespace _0234._Palindrome_Linked_List__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);

            reverse(l1);

            //Console.WriteLine(IsPalindrome(l1));
        }


        public static bool IsPalindrome(ListNode head)
        {
            ListNode fast = head, slow = head;

            //向前走
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next; //走兩步
                slow = slow.next; // 走一步
            }

            //如果 list 節點數為奇數則 fast 不會為 null，slow必須往前一步
            if (fast != null)
            {
                slow = slow.next;
            }

            //反轉 slow 以下節點
            slow = reverse(slow);

            //比較反轉後的區段
            fast = head;

            while (slow != null)
            {
                if (fast.val != slow.val)
                {
                    return false;
                }

                fast = fast.next;
                slow = slow.next;
            }

            return true;
        }

        public static ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }

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
}
