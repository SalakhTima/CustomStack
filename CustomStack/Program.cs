
namespace CustomStack;

internal class Program 
{ 
    private static void Main()
    {
        var stack = new CustomStack<int>(10);

        stack.Push(6);
        stack.Push(19);
        stack.Push(-91);
        stack.Push(0);
        stack.Push(3);
        stack.Push(1);

        stack.Sort();

        stack.Pop();
        stack.Push(2);

        foreach (int e in stack)
        {
            Console.WriteLine(e);
        }
    }
}