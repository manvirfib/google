public class copyRandomLinkedList
{
    public Node copyRandomList(Node head)
    {
        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();

        Node old = head;
        while (old != null)
        {
            oldToNew[old] = new Node(old.val);
            old = old.next;
        }

        old = head;
        while (old != null)
        {
            Node newNode = oldToNew[old];
            newNode.next = old.next != null ? oldToNew[old.next] : null;
            newNode.random = old.random != null ? oldToNew[old.random] : null;
            old = old.next;
        }

        return head != null ? oldToNew[head] : null;
    }
}

public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}