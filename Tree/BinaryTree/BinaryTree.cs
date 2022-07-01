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

    public BinaryNode<T> Search(T value)
    {
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

    public int Size()
    {
        throw new NotImplementedException();
    }

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
}