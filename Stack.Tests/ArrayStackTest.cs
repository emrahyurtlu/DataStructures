namespace Stack.Tests;

public class ArrayStackTest
{
    [Fact]
    public void TestStackIsNull()
    {
        var stack = new ArrayStack<int>();
        Assert.Throws<EmptyStackException>(() => stack.Peek());
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(6)]
    public void TheoryPushElements(int number)
    {
        var stack = new ArrayStack<int>(4);

        stack.Push(number);
        Array.Equals(number, stack.Peek());
    }

    [Fact]
    public void TestArrayResize()
    {
        var stack = new ArrayStack<int>(4);

        stack.Push(1);
        Assert.Equal(1, stack.Peek());
        Assert.Equal(4, stack.Capacity());

        stack.Push(2);
        Assert.Equal(2, stack.Peek());
        Assert.Equal(4, stack.Capacity());

        stack.Push(3);
        Assert.Equal(3, stack.Peek());
        Assert.Equal(4, stack.Capacity());

        stack.Push(4);
        Assert.Equal(4, stack.Peek());
        Assert.Equal(4, stack.Capacity());

        stack.Push(5);
        Assert.Equal(5, stack.Peek());
        Assert.Equal(8, stack.Capacity());
    }
}