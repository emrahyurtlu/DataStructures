namespace Tree.BinaryTree;

public class BinaryNode<T>
{
    public BinaryNode(T data)
    {
        Data = data;
    }

    public T? Data { get; set; }

    public BinaryNode<T> Root { get; set; }
    
    public BinaryNode<T> Right { get; set; }

    public BinaryNode<T> Left { get; set; }
}