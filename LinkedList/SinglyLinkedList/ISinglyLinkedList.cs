using System;
namespace LinkedList
{
    public interface ISinglyLinkedList<T>
    {
        void AddFirst(T element);

        void AddLast(T element);

        T Remove(T element);

        void RemoveAll();

        int Length();

        bool IsEmpty();

        SinglyNode<T>? Has(T element);

        List<T> ToList();

        SinglyNode<T> Head();

        SinglyNode<T> Tail();

        void Print();
    }
}