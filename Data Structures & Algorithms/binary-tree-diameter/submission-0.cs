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

    private int diameter = 0;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        GetHeight(root);
        return diameter;
    }

    private int GetHeight(TreeNode node)
    {
        if (node == null)
            return 0;

        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);

        // Diameter passing through this node
        diameter = Math.Max(diameter, leftHeight + rightHeight);

        // Return height of the current subtree
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
