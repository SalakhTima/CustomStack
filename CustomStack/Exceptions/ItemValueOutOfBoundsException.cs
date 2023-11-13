
namespace CustomStack.Exceptions;

internal class ItemValueOutOfBoundsException : BoundaryException
{
    public dynamic? Item { get; }
    public ItemValueOutOfBoundsException() { }
    public ItemValueOutOfBoundsException(string message) : base(message) { }
    public ItemValueOutOfBoundsException(string message, ExceptionCodes code) : base(message, code) { }
    public ItemValueOutOfBoundsException(string message, ExceptionCodes code, dynamic item) : base(message, code)
    {
        Item = item;
    }
}