public class LRUCache {


class Node
    {
        public int key;
        public int value;
        public Node prev;
        public Node next;

        public Node(int key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }

    private int capacity;
    private Dictionary<int, Node> cache;

    private Node left;
    private Node right;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new();
        left = new Node(0,0);
        right = new Node(0,0);

        left.next = right;
        right.prev = left;
    }
    
    public int Get(int key) {
        
        if(!cache.ContainsKey(key))
        {
           return -1;
        }
        Node node = cache[key];
        removeNode(node);
        inserttoEnd(node);
        return node.value;
    }
    
    public void Put(int key, int value) {
      
      if(cache.ContainsKey(key))
      {
        removeNode(cache[key]);
      }
      Node node = new Node(key, value);

        cache[key] = node;

        // Most recently used
        inserttoEnd(node);
        if (cache.Count > capacity)
        {
            // Remove least recently used
            Node lru = left.next;

            removeNode(lru);
            cache.Remove(lru.key);
        }
    }


     void inserttoEnd(Node node)
    {
       Node prev = right.prev;
        Node next = right;

        prev.next = node;
        node.prev = prev;

        node.next = next;
        next.prev = node;
    }

     void removeNode(Node node)
    {
        Node prev = node.prev;
        Node next = node.next;

        prev.next = next;
        next.prev = prev;
    }
}
