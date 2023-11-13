
namespace CustomStack.Exceptions;

internal class BoundaryException : Exception
{
    public ExceptionCodes Code { get; }
    public BoundaryException() { }
    public BoundaryException(string message) : base(message) { }
    public BoundaryException(string message, ExceptionCodes code) : base(message)
    {
        Code = code;
    }
}