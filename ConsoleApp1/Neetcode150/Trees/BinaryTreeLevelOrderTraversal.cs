public class LevelOrderTraversalBst {
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> result = new List<List<int>>();

        if(root == null) {
            return new List<List<int>>();
        }

        q.Enqueue(root);

        while(q.Count > 0){
            int size = q.Count;
            List<int> newList = new List<int>();
            for(int i = 0; i < size; i++){
                var node = q.Dequeue();
                newList.Add(node.val);
                if(node.left != null){
                    q.Enqueue(node.left);
                }
                if(node.right != null){
                    q.Enqueue(node.right);
                }
            }
            result.Add(newList);
        }

        return result;
    }
}