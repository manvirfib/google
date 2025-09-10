public class LowestCommonAncestorTree {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null)
        return null;

        if(p.val < root.val && q.val < root.val){
            return LowestCommonAncestor(root.left, p, q);
        }
        if(p.val > root.val && q.val > root.val){
            return LowestCommonAncestor(root.right, p, q);
        }

        return root;
    }
}