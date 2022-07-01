namespace Stack.Tests;

public class LinkStackTest
{
    [Fact]
    public void TestPeekElementThrowsException()
    {
        var stack = new LinkedStack<int>();
        Assert.Throws<EmptyStackException>(() => stack.Peek());
    }

    [Fact]
    public void TestGetPeekElement()
    {
        var stack = new LinkedStack<int>();
        stack.Push(1);
        Assert.Equal(1, stack.Peek());
    }

    [Fact]
    public void TestPushElement()
    {
        var stack = new LinkedStack<int>();
        stack.Push(1);
        Assert.Equal(1, stack.Pop());
    }

    [Fact]
    public void TestPopElement()
    {
        var stack = new LinkedStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();

        Assert.NotEqual(3, stack.Peek());
    }
}