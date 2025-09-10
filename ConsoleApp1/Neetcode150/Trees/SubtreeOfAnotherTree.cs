public class Subtree {   
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null)
        return true;

        if(p == null && q != null)
        return false;

        if(p != null && q == null)
        return false;

        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }

    public bool IsSubtree(TreeNode root, TreeNode sub) {
        if(sub == null) return true;
        if(root == null) return false;

        return IsSameTree(root, sub) || IsSubtree(root.left, sub) || IsSubtree(root.right, sub);
    }
}