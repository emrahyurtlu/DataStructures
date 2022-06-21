using System;
namespace Queue
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException() : base("Queue is empty!")
        {
        }
    }
}

