public class ValidBinarySearchTree {
    bool dfs(TreeNode root, int min, int max){
        if(root == null)
        return true;

        if(root.val <= min || root.val >= max)
        return false;

        return dfs(root.left, min, root.val) && dfs(root.right, root.val, max);
    }
    public bool IsValidBST(TreeNode root) {
        return dfs(root, int.MinValue, int.MaxValue);
    }
}