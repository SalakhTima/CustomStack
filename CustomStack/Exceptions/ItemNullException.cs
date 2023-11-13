
namespace CustomStack.Exceptions;

internal class ItemNullException : Exception
{
    public ExceptionCodes Code { get; }
    public ItemNullException() { }
    public ItemNullException(string message) : base(message) { }
    public ItemNullException(string message, ExceptionCodes code) : base(message)
    {
        Code = code;
    }
}