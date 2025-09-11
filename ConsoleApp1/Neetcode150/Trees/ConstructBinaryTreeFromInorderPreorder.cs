public class ConstructBinaryTree {
    Dictionary<int, int> dict = new Dictionary<int, int>();
    int[] pre, inor;
    int pindex = 0;
    public TreeNode dfs(int Istart, int Iend){
        if(Istart > Iend || pindex >= pre.Length)
        return null;

        var node = new TreeNode(pre[pindex]);
        int midIndex = dict[pre[pindex]];
        pindex++;
        node.left = dfs(Istart, midIndex - 1);
        node.right = dfs(midIndex + 1, Iend);

        return node;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for(int i = 0; i < inorder.Length; i++){
            dict[inorder[i]] = i;
        }
        int n = inorder.Length;
        pre = preorder;
        inor = inorder;
        return dfs(0, n - 1);
    }
}