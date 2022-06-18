﻿namespace LinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public Node<T> Prev { get; set; }

        public Node(T Data)
        {
            this.Data = Data;
        }
    }
}

