namespace Tree.BinaryTree;

public interface IBinaryTree<T>
{
    T Add(T value);

    void Remove(T value);

    Node<T> Search(T value);

    int Height();
    
    int Level();
    
    int Size();
}