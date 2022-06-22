using LinkedList.SinglyLinkedList;

namespace Stack;

public class LinkedStack<T> : IStack<T>
{
    private readonly SinglyLinkedList<T> _linkedList;
    private readonly int _size = 0;

    public LinkedStack()
    {
        _linkedList = new SinglyLinkedList<T>();
    }

    public T Peek()
    {
        if (_size == 0)
            throw new EmptyStackException();

        return _linkedList.Tail().Data;
    }

    public T Pop()
    {
        return _linkedList.Remove(_linkedList.Tail().Data);
    }

    public void Push(T element)
    {
        _linkedList.AddLast(element);
    }

    public int Size()
    {
        return _size;
    }
}