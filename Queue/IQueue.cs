namespace Queue;

public interface IQueue<T>
{
    void Enqueue(T element);

    T Dequeue();

    T Peek();

    int Size();

    bool Contains(T element);

    void Clear();
}