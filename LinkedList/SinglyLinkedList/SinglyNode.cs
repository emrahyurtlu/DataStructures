namespace LinkedList;

public class SinglyNode<T>
{
    public SinglyNode(T Data)
    {
        this.Data = Data;
    }

    public T Data { get; set; }

    public SinglyNode<T> Next { get; set; }
}