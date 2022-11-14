using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodePracticeConsole{
  
  public class MergeLists{

        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        //check for null
        if (list1 == null) {return list2;}
        else if (list2 == null){return list1;}
        //create new node set
        ListNode d = new ListNode();
        //something to keep track of the current one starting at d
        ListNode cur = d;
        //while we haven't reached the end of the list
        while (list1 != null && list2 != null){
            //if list one contains a bigger value it goes next
            if (list1.val < list2.val){
                cur.next = list1;
                list1 = list1.next;
            }
            //if list 2 contains the bigger value it goes next
            else{
                cur.next = list2;
                list2 = list2.next;
            }
            //advance current by one
            cur = cur.next;
        }
        //if a list is finished grab last value from the next list
        if (list1 != null) {cur.next = list1;}
        
        if (list2 != null) {cur.next = list2;}
        //return finished list
        return d.next;
    }
  }
}