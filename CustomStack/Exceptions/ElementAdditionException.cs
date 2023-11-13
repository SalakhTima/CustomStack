
namespace CustomStack.Exceptions;

internal class ElementAdditionException : InvalidOperationException
{
    public dynamic? Item { get; }
    public ElementAdditionException() { }
    public ElementAdditionException(string message) : base(message) { }
    public ElementAdditionException(string message, ExceptionCodes code) : base(message, code) { }
    public ElementAdditionException(string message, ExceptionCodes code, dynamic item)
        : base(message, code)
    {
        Item = item;
    }
}