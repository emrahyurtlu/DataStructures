namespace LinkedList.DoublyLinkedList
{
    public class DoublyNode<T>
    {
        public T Data { get; set; }

        public DoublyNode<T> Next { get; set; }

        public DoublyNode<T> Prev { get; set; }

        public DoublyNode(T Data)
        {
            this.Data = Data;
        }
    }
}