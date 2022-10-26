using System.Collections;

public class Queues
{
    Queue queue = new Queue();

    public Queues()
    {
        queue.Enqueue(123);
        queue.Enqueue("Second in");
        queue.Enqueue("3rd in");

    }

    public void Enqueue()
    {
        Console.WriteLine("Enter element to add to queue -  Enqueue: ");
        queue.Enqueue(Console.ReadLine());
    }

    public void Dequeue()
    {
        Console.WriteLine($"Removed by FIFO Principle - Dequeue: {queue.Dequeue()} ");
    }

    public void Display()
    {
        foreach(var item in queue)
        {
            Console.WriteLine($"{item} ");
        }
    }

    public Queue clone()
    {
        return (Queue)queue.Clone();
    }

}
