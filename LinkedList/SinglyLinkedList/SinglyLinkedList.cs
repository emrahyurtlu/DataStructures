namespace LinkedList.SinglyLinkedList;

public class SinglyLinkedList<T> : ISinglyLinkedList<T>
{
    private SinglyNode<T> _head;

    private SinglyNode<T> _tail;

    private int _count;

    public SinglyLinkedList()
    {
        _head = null;
        _tail = null;
        Elements = new List<T>();
    }

    private List<T> Elements { get; }

    public void AddFirst(T element)
    {
        var node = new SinglyNode<T>(element);

        if (_head is null)
        {
            _head = _tail = node;
        }
        else
        {
            node.Next = _head;
            _head = node;
        }

        _count++;
        Elements.Add(element);
    }

    public void AddLast(T element)
    {
        var node = new SinglyNode<T>(element);

        if (_tail is null)
        {
            _head = _tail = node;
        }
        else
        {
            _tail.Next = node;
            _tail = node;
        }

        _count++;
        Elements.Add(element);
    }

    public T Remove(T element)
    {
        if (_head is null)
            throw new EmptyLinkedListException();

        SinglyNode<T> prev = null;
        for (var node = _head; node != null; node = node.Next)
        {
            if (node.Data != null && node.Data.Equals(element))
            {
                if (prev == null) _head = node.Next;
                else prev.Next = node.Next;
                _count--;
                Elements.Remove(element);
                return node.Data;
            }

            prev = node;
        }

        return default;
    }

    public void RemoveAll()
    {
        if (_head is null)
            throw new EmptyLinkedListException();

        for (var node = _head; node != null; node = node.Next) Remove(node.Data);
    }

    public int Length()
    {
        return _count;
    }

    public bool IsEmpty()
    {
        return _count == 0;
    }

    public SinglyNode<T>? Contains(T element)
    {
        for (var node = _head; node != null; node = node.Next)
            if (node.Data != null && node.Data.Equals(element))
                return node;

        return null;
    }

    public List<T> ToList()
    {
        return Elements;
    }

    public SinglyNode<T> Head()
    {
        if (_head is null)
            throw new EmptyLinkedListException();

        return _head;
    }

    public SinglyNode<T> Tail()
    {
        if (_head is null)
            throw new EmptyLinkedListException();

        return _tail;
    }

    public void Print()
    {
        var node = _head;

        while (node.Next is not null)
        {
            Console.Write(node.Data + " ");
            node = node.Next;
        }
    }
}