public class Diameter {
    int res = 0;
    int Dia(TreeNode root){
        if(root == null)
        return 0;
        int left = Dia(root.left);
        int right = Dia(root.right);
        res = Math.Max(res, left + right);
        return 1 + Math.Max(left, right);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        int value = Dia(root);
        return Math.Max(value - 1, res);
    }
}