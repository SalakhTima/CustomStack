using System.Collections;

namespace CustomStack;

internal class ListEnumerator : IEnumerator
{
    private readonly CustomList _list;
    private int _currentIndex = -1;

    public ListEnumerator(CustomList list) => _list = list;

    public dynamic? Current
    {
        get
        {
            if (_currentIndex == -1 || _currentIndex > _list.Count)
            {
                throw new ArgumentException();
            }
            return _list[_currentIndex];
        }
    }

    object? IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (_currentIndex >= _list.Count - 1) return false;
        _currentIndex++;

        return true;
    }

    public void Reset() => _currentIndex = -1;
}