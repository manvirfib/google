public class KthSmallestInBST {
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if(root == null) return -1;
        stack.Push(root);

        while(stack.Count > 0){
            var node = stack.Pop();
            if(node.left != null && node.val >= 0){
                node.val = -node.val;
                stack.Push(node);
                stack.Push(node.left);
            }
            else{
                k--;
                if(k == 0)
                return Math.Abs(node.val);
                if(node.right != null){
                    stack.Push(node.right);
                }
            }
        }

        return 0;
    }
}