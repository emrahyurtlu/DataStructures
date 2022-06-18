using System;
namespace LinkedList
{
    public interface ILinkedList<T>
    {
        void AddFirst(T element);

        void AddLast(T element);

        void Remove(T element);

        int Length();

        bool IsEmpty();

        Node<T>? Has(T element);

        List<T> ToList();

        T Head();

        T Tail();

        void Print();
    }
}

