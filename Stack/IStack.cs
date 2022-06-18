namespace Stack;
public interface IStack<T>
{
    T Peek();

    T Pop();

    void Push(T element);

    int Size();
}

