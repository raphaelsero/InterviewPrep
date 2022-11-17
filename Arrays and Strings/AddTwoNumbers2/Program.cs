/*
You are given two non-empty linked lists representing two non-negative integers. 
The most significant digit comes first and each of their nodes contains a single digit.
Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Input: l1 = [7,2,4,3], l2 = [5,6,4]
Output: [7,8,0,7]

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [8,0,7]

Input: l1 = [0], l2 = [0]
Output: [0]
 
Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
 
Follow up: Could you solve it without reversing the input lists?
*/

namespace AddTwoNumbers2
{
    class Program 
    {
        public static void Main(string[] args)
        { 
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

        //Time complexity:(N 1 +N 2 ), where N 1+N 2 is a number of elements in both lists
        //Space complexity: O(1) space complexity without taking the output list into account, and O(max(N 1 ,N 2 )) to store the output list.
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int l1Length = GetListLength(l1), l2Length = GetListLength(l2);
            ListNode dummy1 = new ListNode(), dummy2 = new ListNode();

            dummy1.next = l1;
            dummy2.next = l2;

            if (l1Length != l2Length)
            {
                if (l2Length > l1Length)
                    return AddTwoNumbers(l2, l1);

                var zerosDummy = new ListNode();
                ListNode zeroHead = zerosDummy;

                for (; l2Length != l1Length; l2Length++)
                {
                    zerosDummy.next = new ListNode(0);
                    zerosDummy = zerosDummy.next;
                }

                dummy2.next = zeroHead.next;
                zerosDummy.next = l2;
            }

            ListNode sum = Sum(dummy1.next, dummy2.next);
            if (sum.val > 9)
            {
                sum.val %= 10;
                return new ListNode(1, sum);
            }

            return sum;
        }

        private static int GetListLength(ListNode l)
        {
            int length = 0;
            for (; l != null; l = l.next)
                length++;

            return length;
        }

        private static ListNode Sum(ListNode l1, ListNode l2)
        {
            ListNode next = null;
            if (l1.next != null && l2.next != null)
                next = Sum(l1.next, l2.next);

            var node = new ListNode(l1.val + l2.val);
            if (next != null)
            {
                node.val += (next.val / 10);
                next.val %= 10;
            }

            node.next = next;

            return node;
        }

    }
}