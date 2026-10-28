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
    public bool IsValidBST(TreeNode root) {
        Queue<(TreeNode node, long min, long max)> queue = new();

        queue.Enqueue((root, long.MinValue, long.MaxValue));

        while (queue.Count > 0)
        {
            var (node, min, max) = queue.Dequeue();

            // Check whether the current node is within its valid range
            if (node.val <= min || node.val >= max)
                return false;

            // Add left child with an updated upper bound
            if (node.left != null)
            {
                queue.Enqueue((node.left, min, node.val));
            }

            // Add right child with an updated lower bound
            if (node.right != null)
            {
                queue.Enqueue((node.right, node.val, max));
            }
        }

        return true;


    }
}
