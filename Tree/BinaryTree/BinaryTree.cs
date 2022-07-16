namespace Tree.BinaryTree;

public class BinaryTree<T> : IBinaryTree<T>
{
    // Number of nodes
    private int _numberOfNodes = 0;

    private BinaryNode<T> _rootNode;

    public BinaryTree(T value)
    {
        _rootNode = new BinaryNode<T>(value);
        _numberOfNodes++;
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

    //Length of highest path
    public int Height() => (int)Math.Log2((_numberOfNodes + 1) / 2);

    public int Level() => (int)(Math.Log2(_numberOfNodes + 1) - 1);

    public int Size() => _numberOfNodes;

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

    public int NumberOfEdges() => _numberOfNodes != 0 ? _numberOfNodes - 1 : 0;

    public bool IsFull()
    {
        // All nodes should have either 0 or 2 children
        throw new NotImplementedException();
    }

    public bool IsComplete()
    {
        //All nodes must have 2 children or leaf nodes can have only left child.
        throw new NotImplementedException();
    }

    // All nodes have 2 children.
    public bool IsPerfect() => _numberOfNodes == Math.Pow(2, Level() + 1) - 1;
    public bool IsBalanced()
    {
        throw new NotImplementedException();
    }
}