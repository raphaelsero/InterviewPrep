/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. 
Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.

Input: l1 = [0], l2 = [0]
Output: [0]

Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
 
Constraints:

The number of nodes in each linked list is in the range [1, 100].
0 <= Node.val <= 9
It is guaranteed that the list represents a number that does not have leading zeros.
 
 */


using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Collections;

namespace AddTwoNumbers 
{
    class Program {
        public static void Main(string[] args)
        {
            //TODO: Add test cases
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

        // Time complexity : O(\max(m, n))O(max(m, n)). Assume that mm and nn represents the length of l1l1 and l2l2 respectively,
        // the algorithm above iterates at most \max(m, n)max(m, n) times.

        // Space complexity : O(\max(m, n))O(max(m, n)). The length of the new list is at most \max(m, n) + 1max(m, n)+1

        //Initialize current node to dummy head of the returning list.
        //Initialize carry to 0.
        //Loop through lists l1 and l2 until you reach both ends and carry is 0.
        //Set xx to node l1's value. If l1 has reached the end of l1, set to 0.
        //Set yy to node l2's value. If l2 has reached the end of l2, set to 0.
        //Set sum = x + y + carry
        //Update carry = sum / 10
        //Create a new node with the digit value of(sum % 10) and set it to current node's next, then advance current node to next.
        //Advance both l1 and l2.
        //Return dummy head's next node.
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode dummy = new ListNode(0);
            ListNode pre = dummy;

            while (l1 != null || l2 != null || carry == 1)
            {
                int sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                carry = sum < 10 ? 0 : 1;
                pre.next = new ListNode(sum % 10);
                pre = pre.next;

                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            return dummy.next;
        }


    }
}