/*
Given the head of a singly linked list, reverse the list, and return the reversed list.

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]

Input: head = [1,2]
Output: [2,1]

Input: head = []
Output: []
 

Constraints:
The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 

Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?

 * Definition for singly-linked list.

 
 */

using System.Runtime.Versioning;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: implement test cases
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

        public ListNode IterativelyReverseLinkedList(ListNode head) //Time: O(n), Space O(1)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode tmpNext;

            while(curr != null)
            {
                tmpNext = curr.next; 
                curr.next = prev;
                prev = curr;
                curr = tmpNext;
            }
            return prev;
        }
        //  1    |    2    |    3     |    4    |    5
        // curr  |         |          |         |           tmpNext was initially 2,      curr.next = null,   prev = null
        // prev  |   curr  |          |         |           tmpNext was initially 3,      curr.next = null 
        //       |   prev  |   curr   |         |           tmpNext was initially 4,      curr.next = 1
        //       |         |   prev   |   curr  |           tmpNext was initially 5,      curr.next = 2        
        //       |         |          |   prev  |   curr    tmpNext was initially null,   curr.next = 3
        //       |         |          |         |   prev    tmpNext was initially null,   curr.next = null,   prev = null,   curr = null


        public ListNode RecursivelyReverseLinkedList(ListNode head) //Time O(n), Space O(n)
        {
            if (head == null) return null;
            ListNode newHead = head;

            if (head.next != null)
            {
                newHead = RecursivelyReverseLinkedList(head.next);
                head.next.next = head;
            }
            head.next = null;

            return newHead;
        }
        //  1    |    2    |    3     |    4    |    5
        //newHead|         |          |         |           head.next = 2,     head = 1
        //       | newHead |          |         |           head.next = 3,     head = 2
        //       |         | newHead  |         |           head.next = 4,     head = 3
        //       |         |          | newHead |           head.next = 5,     head = 4  
        //       |         |          |         | newHead   head.next = null,  head = 5     
        //       |         |          |         |           newHead = null     head = 5
    }
}