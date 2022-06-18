using System;
namespace LinkedList
{
    public class DoublyLinkList<T> : ILinkedList<T>
    {

        private Node<T> _head = null;

        private Node<T> _tail = null;

        private int _count = 0;

        private List<T> Elements { get; set; }

        public DoublyLinkList()
        {
            Elements = new List<T>();
        }

        public void AddFirst(T element)
        {
            var node = new Node<T>(element);

            if (_head is null)
            {
                _head = _tail = node;
            }
            else
            {
                var temp = _head;
                node.Next = _head;
                _head = node;
                temp.Prev = node;
            }

            _count++;
            Elements.Add(element);
        }

        public void AddLast(T element)
        {
            var node = new Node<T>(element);

            if (_tail is null)
            {
                _head = _tail = node;
            }
            else
            {
                var temp = _tail;
                _tail.Next = node;
                _tail = node;
                _tail.Prev = temp;
            }

            _count++;
            Elements.Add(element);
        }

        public T Remove(T element)
        {
            T removedElement = default;
            if (_head is null)
                throw new EmptyLinkedListException();

            if (_head.Data.Equals(element))
            {
                _head = _head.Next;
            }
            else
            {
                for (Node<T> node = _head.Next; node != null; node = node.Next)
                {
                    if (node.Data.Equals(element))
                    {
                        node.Prev.Next = node.Next;
                        node.Next.Prev = node.Prev;
                        _count--;
                        Elements.Remove(element);
                        removedElement = element;
                        break;
                    }
                }
            }

            return removedElement;
        }

        public int Length() => _count;

        public bool IsEmpty() => _count == 0;

        public Node<T>? Has(T element)
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

        public T Head() => _head.Data;

        public T Tail() => _tail.Data;

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

