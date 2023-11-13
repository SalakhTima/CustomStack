using CustomStack.Exceptions;

namespace CustomStack;

internal class CustomList
{
    public Node? Top { get; private set; }
    public int Count { get; private set; }

    public dynamic? this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfBoundsException(
                    "Incorrect index entered.",  
                    ExceptionCodes.IndexOutOfBoundsException, index);
            }

            var current = Top;
            for (var i = 0; i < index; i++)
            {
                current = current!.Next;
            }

            return current!.Data;
        }
        set
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfBoundsException(
                    "Incorrect index entered.", 
                    ExceptionCodes.IndexOutOfBoundsException, index);
            }

            var current = Top;
            for (var i = 0; i < index; i++)
            {
                current = current!.Next;
            }

            current!.Data = value;
        }
    }

    public void Add(dynamic item)
    {
        var newNode = new Node{ Data = item };

        if (Top is null)
        {
            Top = newNode;
        }
        else
        {
            newNode.Next = Top;
            Top = newNode;
        }
        Count++;
    }

    public dynamic? RemoveTop()
    {
        if (Top is null)
        {
            throw new ItemNullException("Top item was null.",
                ExceptionCodes.ItemNullException);
        }

        var current = Top;
        Top = Top.Next;
        Count--;
        return current.Data;
    }
}   