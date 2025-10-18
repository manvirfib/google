namespace graph{
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public class CloneGraphSolution {
        void dfs(Node node, Dictionary<Node, Node> oldToNew) {
            if (!oldToNew.ContainsKey(node)) {
                var copy = new Node(node.val);
                oldToNew[node] = copy;
                foreach (var neigh in node.neighbors) {
                    dfs(neigh, oldToNew);
                }
            }
        }
        public Node CloneGraph(Node node) {
            if (node == null) return null;
            Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
            dfs(node, oldToNew);

            foreach (var data in oldToNew) {
                foreach (var neigh in data.Key.neighbors) {
                    data.Value.neighbors.Add(oldToNew[neigh]);
                }
            }

            return oldToNew[node];
        }
    }
}
