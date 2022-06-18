namespace LinkedList.Test;

using LinkedList;
public class DoublyLinkedListTest
{
    [Fact]
    public void TestLinkedListIsNull()
    {
        var linkedList = new DoublyLinkList<int>();
        Assert.True(linkedList.IsEmpty());
    }

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void TheoryAddFirstNewInteger(int number)
    {
        var linkedList = new DoublyLinkList<int>();
        linkedList.AddFirst(number);

        Assert.IsType<Node<int>>(linkedList.Has(number));
    }


    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void TheoryAddLastNewInteger(int number)
    {
        var linkedList = new DoublyLinkList<int>();
        linkedList.AddLast(number);

        Assert.IsType<Node<int>>(linkedList.Has(number));
    }

    [Fact]
    public void TestHasNotThree()
    {
        var linkedList = new DoublyLinkList<int>();

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

        Assert.IsNotType<Node<int>>(linkedList.Has(3));
    }

    [Fact]
    public void TextPrev1AndNext3()
    {
        var linkedList = new DoublyLinkList<int>();

        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        Assert.Equal(3, linkedList.Length());

        var node = linkedList.Has(2);

        Assert.Equal(1, node.Prev.Data);
        Assert.Equal(3, node.Next.Data);
    }
}
