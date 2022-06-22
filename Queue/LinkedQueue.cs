using LinkedList.SinglyLinkedList;

namespace Queue;

public class LinkedQueue<T> : IQueue<T>
{
    private readonly SinglyLinkedList<T> _linkedList;

    private int _size;

    public LinkedQueue()
    {
        _linkedList = new SinglyLinkedList<T>();
        _size = 0;
    }

    public void Clear()
    {
        if (_size == 0) throw new EmptyQueueException();

        _linkedList.RemoveAll();

        _size = 0;
    }

    public bool Contains(T element)
    {
        return _linkedList.Contains(element) is not null;
    }

    public T Dequeue()
    {
        var value = _linkedList.Head().Data;
        _linkedList.Remove(_linkedList.Head().Data);
        _size--;
        return value;
    }

    public void Enqueue(T element)
    {
        _linkedList.AddLast(element);
        _size++;
    }

    public T Peek()
    {
        return _linkedList.Head().Data;
    }

    public int Size()
    {
        return _size;
    }
}