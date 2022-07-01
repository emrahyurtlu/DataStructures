namespace Stack;

public class ArrayStack<T> : IStack<T>
{
    private T[] arr;
    private int capacity;
    private int size;

    public ArrayStack(int capacity = 100)
    {
        this.capacity = capacity;
        arr = new T[capacity];
    }

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
        if (size == arr.Length) Enlarge();

        arr[size++] = element;
    }

    public int Size()
    {
        return size;
    }

    public int Capacity()
    {
        return capacity;
    }

    private void Enlarge()
    {
        capacity = size * 2;
        Array.Resize(ref arr, capacity);
    }
}