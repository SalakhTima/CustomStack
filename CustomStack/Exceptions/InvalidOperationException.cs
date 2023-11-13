
namespace CustomStack.Exceptions;

internal class InvalidOperationException : Exception
{
    public ExceptionCodes Code { get; }
    public InvalidOperationException() { }
    public InvalidOperationException(string message) : base(message) { }
    public InvalidOperationException(string message, ExceptionCodes code) : base(message)
    {
        Code = code;
    }
}