using System;
namespace Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        /// <summary>
        /// arr holds the data of the queue
        /// </summary>
        private T[] arr;

        /// <summary>
        /// indicator is used to enqueue of the current element.
        /// </summary>
        private int indicator = 0;

        /// <summary>
        /// size is used for the quantity of the elements in the queue
        /// </summary>
        private int size = 0;

        /// <summary>
        /// capacity is related for the queue length whether indices are full or empty
        /// </summary>
        private int capacity;

        public ArrayQueue(int capacity = 100)
        {
            this.capacity = capacity;
            arr = new T[capacity];
        }

        public void Clear()
        {
            if (size == 0)
            {
                throw new EmptyQueueException();
            }

            Array.Clear(arr);
            size = indicator = 0;
        }

        public bool Contains(T element)
        {
            return arr.Contains<T>(element);
        }

        public T Dequeue()
        {
            size--;
            return arr[indicator++];
        }

        public void Enqueue(T element)
        {
            if (size == capacity)
            {
                Enlarge();
            }

            arr[size++] = element;
        }

        private void Enlarge()
        {
            capacity *= 2;
            Array.Resize<T>(ref arr, capacity);
        }

        public T Peek() => arr[indicator];

        public int Size() => size;
    }
}

