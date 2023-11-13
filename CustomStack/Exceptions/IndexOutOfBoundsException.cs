
namespace CustomStack.Exceptions;

internal class IndexOutOfBoundsException : BoundaryException
{
    public int Index { get; }
    public IndexOutOfBoundsException() { }
    public IndexOutOfBoundsException(string message) : base(message) { }
    public IndexOutOfBoundsException(string message, ExceptionCodes code) : base(message, code) { }
    public IndexOutOfBoundsException(string message, ExceptionCodes code, int index) : base(message, code)
    {
        Index = index;
    }
}