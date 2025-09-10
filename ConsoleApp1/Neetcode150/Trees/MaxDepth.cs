public class MaxDepthTree {
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return 1 + Math.Max(left, right);
    }
}