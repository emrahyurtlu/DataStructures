namespace Queue.Tests;

public class ArrayQueueTest
{
    [Fact]
    public void TestQueueIsEmpty()
    {
        var queue = new ArrayQueue<int>();
        Assert.Throws<EmptyQueueException>(() => queue.Clear());

        Assert.Equal(0, queue.Size());
        Assert.Equal(0, queue.Peek());
    }

    [Fact]
    public void TestEnqueueIntegers()
    {
        var queue = new ArrayQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Assert.Equal(5, queue.Size());
        Assert.Equal(1, queue.Peek());
    }

    [Fact]
    public void TestDequeueIntegers()
    {
        var queue = new ArrayQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(4, queue.Size());

        Assert.Equal(2, queue.Dequeue());
        Assert.Equal(3, queue.Size());

        Assert.Equal(3, queue.Dequeue());
        Assert.Equal(2, queue.Size());
    }

    [Fact]
    public void TestQueueIsCleared()
    {
        var queue = new ArrayQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Assert.Equal(5, queue.Size());

        queue.Clear();

        Assert.Equal(0, queue.Size());
    }

    [Fact]
    public void TestQueueContains5()
    {
        var queue = new ArrayQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Assert.True(queue.Contains(5));
    }
}