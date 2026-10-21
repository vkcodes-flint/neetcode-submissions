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
    public List<int> RightSideView(TreeNode root) {
        
        List<int> res = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root == null)
        {
            return res;
        }

        queue.Enqueue(root);
        while(queue.Count>0)
        {
            int level = queue.Count;
            for(int  i = 0 ; i < level;i++)
            {
                TreeNode node = queue.Dequeue();
                if(i == level - 1)
                    res.Add(node.val);
                
                if(node.left!=null)
                    queue.Enqueue(node.left);
                if(node.right!=null)
                    queue.Enqueue(node.right);
            }

        }
        return res;
    }
}
