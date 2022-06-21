using System;
namespace LinkedList
{
    public partial class SinglyLinkedList<T> : ISinglyLinkedList<T>
    {
        private SinglyNode<T> _head = null;

        private SinglyNode<T> _tail = null;

        private int _count = 0;

        private List<T> Elements { get; set; }

        public SinglyLinkedList()
        {
            Elements = new List<T>();
        }

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
            for (SinglyNode<T> node = _head; node != null; node = node.Next)
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

            for (var node = _head; node != null; node = node.Next)
            {
                Remove(node.Data);
            }
        }

        public int Length() => _count;

        public bool IsEmpty() => _count == 0;

        public SinglyNode<T>? Has(T element)
        {
            for (var node = _head; node != null; node = node.Next)
            {
                if (node.Data != null && node.Data.Equals(element))
                {
                    return node;
                }
            }

            return null;
        }

        public List<T> ToList() => Elements;

        public SinglyNode<T> Head() => _head;

        public SinglyNode<T> Tail() => _tail;

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
}