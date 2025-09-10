public class CountGoodNodes {
    int Good(TreeNode root, int max){
        if(root == null)
        return 0;
        int count = 0;
        if(root.val >= max){
            count++;
            max = root.val;
        }
        return count + Good(root.left, max) + Good(root.right, max);
    }
    public int GoodNodes(TreeNode root) {
        return Good(root, root.val);
    }
}