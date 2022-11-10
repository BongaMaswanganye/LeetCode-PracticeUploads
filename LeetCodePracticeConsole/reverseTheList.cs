using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole
{
      public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
    public class reverseTheList
    {
        public ListNode ReverseList(ListNode head) {
            //check if theres anything to reverse
            if (head == null) {return null;}
            if (head.next == null) {return head;}

            //need to store the new head of the list
            ListNode newHead = null;
            //need to store where i currently am
            ListNode current = head;
            //need to store the previous node
            ListNode prev = null;
            //need to store the next node 
            ListNode next = null;

            //until you encounter a null node (the end)

            //1->2->3->4->5
            while (current != null){
               //next node is the current nodes next
                next = current.next;
                //current.next is the previous node (at )
                current.next = prev;
                //previous node is assigned to current node
                prev = current;
                //current node is assigned to next one in list
                current = next;
            }
            //assign new head to end
            newHead = prev;
            //return it
            return newHead;
        }
    }
}