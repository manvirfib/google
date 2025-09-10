public class BinaryTreeRightSideView {
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<int> result = new List<int>();

        if(root == null){
            return result;
        }

        q.Enqueue(root);

        while(q.Count > 0){
            int size = q.Count;
            TreeNode node = null;
            for(int i = 0; i < size; i++){
                node = q.Dequeue();
                if(node.left != null){
                    q.Enqueue(node.left);
                }
                if(node.right != null){
                    q.Enqueue(node.right);
                }
            }
            result.Add(node.val);
        }

        return result;
    }
}