namespace LinkedList
{
    public class SinglyNode<T>
    {
        public T Data { get; set; }

        public SinglyNode<T> Next { get; set; }

        public SinglyNode(T Data)
        {
            this.Data = Data;
        }
    }
}

