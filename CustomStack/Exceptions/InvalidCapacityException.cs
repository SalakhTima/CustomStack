
namespace CustomStack.Exceptions;

internal class InvalidCapacityException : BoundaryException
{
    public int Capacity { get; }
    public InvalidCapacityException() { }
    public InvalidCapacityException(string message) : base(message) { }
    public InvalidCapacityException(string message, ExceptionCodes code) : base(message, code) { }
    public InvalidCapacityException(string message, ExceptionCodes code, int capacity) : base(message, code)
    {
        Capacity = capacity;
    }
}