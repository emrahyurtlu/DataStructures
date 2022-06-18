using System;
using LinkedList;
namespace Stack
{
	public class LinkedStack<T> : IStack<T>
	{
        private SinglyLinkedList<T> linkedList;
        private int size = 0;

        public LinkedStack()
        {
            linkedList = new SinglyLinkedList<T>();
        }

        public T Peek()
        {
            if (size == 0)
                throw new EmptyStackException();

            return linkedList.Tail();
        }

        public T Pop()
        {
            return linkedList.Remove(linkedList.Tail());
        }

        public void Push(T element)
        {
            linkedList.AddLast(element);
        }

        public int Size() => size;
    }
}

