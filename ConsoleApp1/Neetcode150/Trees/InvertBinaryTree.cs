public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
public class InvertBinaryTree
{
    void Invert(TreeNode root)
    {
        if (root == null)
            return;
        Invert(root.left);
        Invert(root.right);
        var temp = root.left;
        root.left = root.right;
        root.right = temp;
    }
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return null;
        Invert(root);

        return root;
    }
}