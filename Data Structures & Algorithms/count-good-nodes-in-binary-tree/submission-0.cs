/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int GoodNodes(TreeNode root) {
       Queue<(TreeNode node, int maxSoFar)> queue = new();

        queue.Enqueue((root, root.val));

        int count = 0;

        while (queue.Count > 0)
        {
            var (node, maxSoFar) = queue.Dequeue();

            // Check whether the current node is good
            if (node.val >= maxSoFar)
            {
                count++;
            }

            // Update the maximum value along this path
            int newMax = Math.Max(maxSoFar, node.val);

            // Add the left child
            if (node.left != null)
            {
                queue.Enqueue((node.left, newMax));
            }

            // Add the right child
            if (node.right != null)
            {
                queue.Enqueue((node.right, newMax));
            }
        }

        return count;



    }
}
