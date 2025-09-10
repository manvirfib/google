public class BalancedBinaryTree {
    bool flag = true;
    int HeightOfTree(TreeNode root){
        if(root == null)
            return 0;
        int left = HeightOfTree(root.left);
        int right = HeightOfTree(root.right);
        if(Math.Abs(left - right) > 1)
            flag = false;
        return 1 + Math.Max(left, right);
    }
    public bool IsBalanced(TreeNode root) {
        HeightOfTree(root);
        return flag;
    }
}