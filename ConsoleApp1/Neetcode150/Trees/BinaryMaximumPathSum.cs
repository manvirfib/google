public class MaximumPathSum {
    int result = int.MinValue;
    int Sum(TreeNode root){
        if(root == null)
        return 0;

        int left = Math.Max(0, Sum(root.left));
        int right = Math.Max(0, Sum(root.right));

        result = Math.Max(result, left + right + root.val);

        return Math.Max(left, right) + root.val;
    }
    public int MaxPathSum(TreeNode root) {
        Sum(root);
        return result;
    }
}