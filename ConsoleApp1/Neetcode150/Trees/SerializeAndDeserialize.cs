public class Codec {
    public string Serialize(TreeNode root) {
        List<string> sb = new List<string>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            var node = q.Dequeue();
            if(node == null){
                sb.Add("#");
            }
            else{
                sb.Add(node.val+"");
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
        }

        return string.Join(',', sb);
    }

    public TreeNode Deserialize(string data) {
        var someData = data.Split(',');
        if(someData[0] == "#")
        return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode();
        root.val = int.Parse(someData[0]);
        queue.Enqueue(root);
        int i = 0;
        i++;

        while(queue.Count > 0){
            var node = queue.Dequeue();
            if(someData[i] != "#"){
                var newNode = new TreeNode(int.Parse(someData[i]));
                node.left = newNode;
                queue.Enqueue(newNode);
            }
            i++;
            if(someData[i] != "#"){
                var newNode = new TreeNode(int.Parse(someData[i]));
                node.right = newNode;
                queue.Enqueue(newNode);
            }
            i++;
        }

        return root;
    }
}