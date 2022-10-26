using System.Collections;

public class Stacks
{
    Stack stack = new System.Collections.Stack();

    public Stacks()
    {
        stack = new System.Collections.Stack();
        stack.Push(10);
        stack.Push("Hello!");
    }

    public void push()
    {
        Console.Write("Enter value to push into stack: ");
        stack.Push(Console.ReadLine());
    }

    public void pop()
    {
        if (stack.Count > 0)
            Console.WriteLine(stack.Pop());
        else
            Console.WriteLine("Stack is Empty");
    }

    public object peek()
    {
        if (stack.Count > 0)
            return stack.Peek();
        else
            return ("Empty Stack");
    }

    public void display()
    {
        foreach (var item in stack)
        {
            Console.WriteLine($"{item} ");
        }
    }

}