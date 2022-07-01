namespace LinkedList.DoublyLinkedList;

public interface IDoublyLinkedList<T>
{
    void AddFirst(T element);

    void AddLast(T element);

    T Remove(T element);

    void RemoveAll();

    int Length();

    bool IsEmpty();

    DoublyNode<T>? Has(T element);

    List<T> ToList();

    DoublyNode<T> Head();

    DoublyNode<T> Tail();

    void Print();
}