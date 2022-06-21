namespace LinkedList.Test;

using LinkedList;
public class SinglyLinkedListTest
{
    [Fact]
    public void TestLinkedListIsNull()
    {
        var linkedList = new SinglyLinkedList<int>();
        Assert.True(linkedList.IsEmpty());
    }

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void TheoryAddFirstNewInteger(int number)
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.AddFirst(number);

        linkedList.Has(number);

        Assert.IsType<SinglyNode<int>>(linkedList.Has(number));
    }


    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void TheoryAddLastNewInteger(int number)
    {
        var linkedList = new SinglyLinkedList<int>();
        linkedList.AddLast(number);

        Assert.IsType<SinglyNode<int>>(linkedList.Has(number));
    }

    [Fact]
    public void TestHasNotThree()
    {
        var linkedList = new SinglyLinkedList<int>();

        linkedList.AddLast(1);
        Assert.Equal(1, linkedList.Length());

        linkedList.AddLast(2);
        Assert.Equal(2, linkedList.Length());

        linkedList.AddLast(3);
        Assert.Equal(3, linkedList.Length());

        linkedList.AddLast(4);
        Assert.Equal(4, linkedList.Length());

        linkedList.Remove(3);
        Assert.Equal(3, linkedList.Length());

        Assert.IsNotType<SinglyNode<int>>(linkedList.Has(3));
    }
}
