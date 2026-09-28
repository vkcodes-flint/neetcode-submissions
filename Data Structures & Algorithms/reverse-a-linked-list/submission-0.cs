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
    public ListNode ReverseList(ListNode head) {
        ListNode cur = null, prev = null, forw = null;
        cur = head;
        while(cur!=null)
        {
            forw = cur.next;
            cur.next = prev;
            prev = cur;
            cur = forw;
        }
        head = cur;
        return prev; 
    }
}
