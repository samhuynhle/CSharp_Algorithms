/*
 Definition for a binary tree node.
*/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

// Using a stack to traverse through the binary search tree
public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        HashSet<int> hash = new HashSet<int>();

        var current = root;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count > 0){
            TreeNode node = stack.Pop();
            int remainder = k - node.val;
            if(hash.Contains(remainder)){
                return true;
            }

            hash.Add(node.val);
            if(node.left != null){
                stack.Push(node.left);
            }
            if(node.right != null){
                stack.Push(node.right);
            }
        }
        return false;
    }
}