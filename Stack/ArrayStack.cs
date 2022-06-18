using System;
namespace Stack
{
    public class ArrayStack<T> : IStack<T>
    {
        private T[] arr;
        private int size = 0;
        private int capacity = 0;

        public ArrayStack(int capacity = 100)
        {
            this.capacity = capacity;
            arr = new T[capacity];
        }

        public int Capacity() => capacity;

        public T Peek()
        {
            if (size == 0)
                throw new EmptyStackException();

            return arr[size - 1];
        }

        public T Pop()
        {
            if (size == 0)
                throw new EmptyStackException();

            var element = arr[--size];
            arr[size] = default;

            return element;
        }

        public void Push(T element)
        {
            if (size == arr.Length)
            {
                Resize();
            }

            arr[size++] = element;
        }

        public int Size() => size;

        private void Resize()
        {
            capacity = size * 2;
            Array.Resize<T>(ref arr, capacity);
        }
    }
}

