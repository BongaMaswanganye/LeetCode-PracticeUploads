using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole{

    //very similar process to contains duplicate
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head) {
        //if no head then no loop
        if (head == null){return false;}
        //if no next node, then head is only value and thus no loop
        if (head.next == null){return false;}
        //its a cycle if a node points to an earlier node so throw the nodes in a hashset
        HashSet<ListNode> Holder = new HashSet<ListNode>();
        //put each node in the set
        ListNode current = head;
        while (current != null)
        {
            //if you cant add the current node, its already in the list, return true
            if (!Holder.Add(current)){
                return true;
            }
            //check next node
            current = current.next;
        }
        //left without repeating value, return false
        return false;
    }
    }
}