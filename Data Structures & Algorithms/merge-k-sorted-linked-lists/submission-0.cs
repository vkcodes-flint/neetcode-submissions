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
    public ListNode MergeKLists(ListNode[] lists) {
        
        PriorityQueue<ListNode, int> minHeap = new();

    // Put the first node of every list into the heap
    foreach (ListNode list in lists)
    {
        if (list != null)
        {
            minHeap.Enqueue(list, list.val);
        }
    }

    ListNode dummy = new ListNode(0);
    ListNode current = dummy;

    while (minHeap.Count > 0)
    {
        // Get the smallest node
        ListNode node = minHeap.Dequeue();

        // Add it to the result
        current.next = node;
        current = current.next;

        // Add the next node from the same list
        if (node.next != null)
        {
            minHeap.Enqueue(node.next, node.next.val);
        }
    }

    return dummy.next;


    }
}
