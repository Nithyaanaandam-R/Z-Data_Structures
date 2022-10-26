using System.Collections;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Data structure - Array, ArrayList, Hashtables, Stacks, Queues, Trees (please enter in all small as you read here) ");

        string choice = Console.ReadLine();

        if (choice == "array") //using array
        {
            Arrays arr = new Arrays();

            Console.WriteLine("Enter 5 values: ");
            arr.read(5);

            arr.operations();
        }
        else if (choice == "arraylist") //using arraylist
        {
            ArrayListEx example = new ArrayListEx();
            example.display();

            Console.WriteLine("\n Adding 5540 into arraylist..");
            example.add(5540);
            example.display();

            Console.WriteLine("\n Insertion at specific points...");
            example.insert();

            example.insertRange();

        }
        else if (choice == "hashtables") //using hashtable
        {
            Hashtables hashtables = new Hashtables();
            hashtables.display();

            hashtables.insert();

            hashtables.methods();
        }

        else if (choice == "stacks") //using stack
        {
            Stacks st = new Stacks();
            st.display();
            st.push();
            
            Console.WriteLine("Peek: " + st.peek());
            st.display();

            Console.Write("Pop: ");
            st.pop();
            st.display();
        } 

        else if (choice == "queues")
        {
            Queues queue = new Queues();
            queue.Display();
            
            Console.WriteLine("Cloning queues: ");
            Queue clone = queue.clone();
            
            queue.Enqueue();
            queue.Display();

            queue.Dequeue();
            queue.Display();

            Console.WriteLine("Displaying clone before enqueue and dequeue: ");
            foreach( var item in clone)
                Console.WriteLine(item);
        } //using queue

        else
        {
            Console.WriteLine("Enter your Root node: ");

            TreeNode comment = new TreeNode(Console.ReadLine());
        child: Console.WriteLine("Would you like to add child to root (Y/N)");

            if (Console.ReadLine() == "y")
            {
                string text = Console.ReadLine();
                TreeNode reply = new TreeNode(text, comment);
                comment.AddChild(reply);

                goto child;
            }

            Console.WriteLine("Your Tree: \n");
            Console.WriteLine(comment.text);
            comment.DisplayChildren();
        } //tree operations
    }
}
