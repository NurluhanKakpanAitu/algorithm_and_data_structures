namespace LinkedList;

public class LinkedList
{
    private Node? Head { get; set; }
    
    private Node? Tail { get; set; }

    private int Count { get; set; }


    public void Add(int data)
    {
        var node = new Node(data);
        if (Head == null)
            Head = node;
        else
            Tail!.Next = node;
        Tail = node;
        Count++;
    }

    public bool Remove(int data)
    {
        var current = Head;
        Node? previous = null;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                        Tail = previous;
                }
                else
                {
                    Head = Head?.Next;
                    if (Head == null)
                        Tail = null;
                }

                Count--;
                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public int Length => Count;
    public bool IsEmpty => Count == 0;

    public bool Contains(int data)
    {
        var current = Head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }

        return false;
    }
}