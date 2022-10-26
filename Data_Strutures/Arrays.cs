public class Arrays
{
    int [] array;

    public void read(int length)
    {
        array = new int[length];
        for (int i = 0; i < length; i++)  
            array[i] = int.Parse(Console.ReadLine());
    }

    public void write()
    {
        Console.WriteLine("Array Elements: ");

        foreach(int i in array)
            Console.Write(" " + i);
    }

    public void operations()
    {
        Console.WriteLine("Sorted Array: ");
        Array.Sort(array);
        foreach (int i in array)
            Console.WriteLine(" " + i);

        Console.WriteLine("\n Reversing the array: ");
        Array.Reverse(array);
        foreach(int i in array)
            Console.WriteLine(" " + i);
    }
}