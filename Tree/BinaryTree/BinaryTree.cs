namespace Tree.BinaryTree;

public class BinaryTree<T> : IBinaryTree<T>
{
    private readonly int _size = 0;
    private BinaryNode<T> _rootNode;

    public BinaryTree()
    {
        _rootNode = null;
    }

    public BinaryTree(T value)
    {
        _rootNode = new BinaryNode<T>(value);
    }

    public T AddLeft(T value)
    {
        throw new NotImplementedException();
    }

    public T AddRight(T value)
    {
        throw new NotImplementedException();
    }

    public void Remove(T value)
    {
        throw new NotImplementedException();
    }

    public BinaryNode<T> DepthFirstSearch(T value)
    {
        /*
         For Iterative Solution:
         Searching function should be implemented by using stack data structure.
         First we should add all nodes into the stack and than use it by popping 
         from stack.
         Complexity: O(n);
         
         For Recursive Solution:
         
         */
        
        throw new NotImplementedException();
    }

    public int Height()
    {
        throw new NotImplementedException();
    }

    public int Level()
    {
        throw new NotImplementedException();
    }

    public int Size() => _size;

    public bool IsLeaf()
    {
        throw new NotImplementedException();
    }

    public int NumberOfLeaves()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T value)
    {
        throw new NotImplementedException();
    }

    public BinaryNode<T> GetRoot() => _rootNode;
}