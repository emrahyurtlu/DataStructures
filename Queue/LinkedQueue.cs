using System;
using LinkedList;
namespace Queue
{
	public class LinkedQueue<T> : IQueue<T>
	{
        private SinglyLinkedList<T> linkedList;

        private int size = 0;

        public LinkedQueue()
		{
            linkedList = new SinglyLinkedList<T>();
		}

        public void Clear()
        {
            if (size == 0)
            {
                throw new EmptyQueueException();
            }

            linkedList.RemoveAll();
            
            size = 0;
        }

        public bool Contains(T element) => linkedList.Has(element) is not null;

        public T Dequeue()
        {
            var value = linkedList.Head().Data;
            linkedList.Remove(linkedList.Head().Data);

            return value;
        }

        public void Enqueue(T element)
        {
            linkedList.AddLast(element);
            size++;
        }

        public T Peek() => linkedList.Head().Data;

        public int Size() => size;
    }
}

