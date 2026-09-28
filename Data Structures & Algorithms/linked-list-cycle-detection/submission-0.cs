/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode fstptr = null;
        ListNode slwptr = null;

        fstptr = head;
        slwptr = head;

        while(fstptr!=null && fstptr.next!=null)
        {
            fstptr = fstptr.next.next;
            slwptr = slwptr.next;
            if(fstptr == slwptr)
            {
                return true;
            }
        }
        return false;
        
    }
}
