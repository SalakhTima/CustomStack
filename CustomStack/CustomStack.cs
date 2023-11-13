using System.Collections;
using CustomStack.Exceptions;

namespace CustomStack;

internal class CustomStack<T> : IEnumerable where T : struct, IComparable
{
    private readonly int _capacity;
    private readonly CustomList _list;
    public int Count => _list.Count;

    public CustomStack(int capacity = 100)
    {
        try
        {
            if (capacity <= 0)
            {
                throw new InvalidCapacityException("Incorrect capacity entered.",
                    ExceptionCodes.InvalidCapacityException, capacity);
            }
        }
        catch (InvalidCapacityException e)
        {
            Console.WriteLine($"{e.Message}\n{e.Capacity}\n{e.Code}");
            capacity = 100;
        }

        _capacity = capacity;
        _list = new CustomList();
    } 
    
    public void Push(T item)
    {
        if (Count == _capacity)
        {
            throw new ElementAdditionException("Permissible capacity exceeded.",
                ExceptionCodes.ElementAdditionException, item);
        }

        if (item is >= 1000 or <= -1000)
        {
            throw new ItemValueOutOfBoundsException("Invalid item value.",
                ExceptionCodes.ItemValueOutOfBoundsException,item);
        }

        _list.Add(item);
    }

    public T Pop() => _list.RemoveTop();
    
    public T Peek()
    {
        if (_list.Top is null)
        {
            throw new ItemNullException("Top was null",
                ExceptionCodes.ItemNullException);
        }
        return _list.Top!.Data;
    }

    public T Find(T item)
    {
        if (_list.Top is null)
        {
            throw new ItemNullException("Top was null",
                ExceptionCodes.ItemNullException);
        }

        foreach (T i in this)
        {
            if (i.Equals(item)) return i;
        }

        return default;
    }

    public T this[int index]
    {
        get => _list[index];
        set => _list[index] = value;
    }

    public IEnumerator GetEnumerator() => new ListEnumerator(_list);

    public void Sort()
    {
        for (var i = 0; i < Count; i++)
        {
            for (var j = 0; j < Count - 1 - i; j++)
            {
                if (this[j].CompareTo(this[j + 1]) > 0)
                {
                    (this[j], this[j + 1]) = (this[j + 1], this[j]);
                }
            }
        }
    }
}