namespace shazebalopolis.console
{
    // List of nodes object
    public class BinaryTree<T>
    {
        // variables 
        BinaryTreeNode<T> _root;

        // constructors 
        public BinaryTree() 
        {
            _root = new BinaryTreeNode<T>(); 
        }

        // methods 
        public void add(BinaryTreeNode<T> node)
        {
            Console.WriteLine($"Node value: \"{node.data}\"");
        }

        public void search(string searchKey)
        {
            Console.WriteLine($"You requested a search on: \"{searchKey}\"");
        }
    }

    // Node object 
    public class BinaryTreeNode<T>
    {
        // properties
        public T data { get; set; }

        // constructors
        public BinaryTreeNode() { }

        public BinaryTreeNode(T _data)
        {
            this.data = _data;
        }

        // methods
    }
}
