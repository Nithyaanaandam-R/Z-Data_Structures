using System.Collections;

public class Hashtables
{
    Hashtable employee = new Hashtable
            {
                { "EId", 1001 },
                { "Name", "James" },
                { "Salary", 3500 },
                { "Location", "Mumbai" },
                { "EmailID", "a@a.com" }
            };
    
    public void insert()
    {
        Console.WriteLine("\n Inserting key-value pair into Hashtable");
        string hash_key;
        Console.Write("Enter key: ");
        hash_key = Console.ReadLine();

        Console.WriteLine("Enter value: ");
        employee.Add(hash_key, Console.ReadLine());

        Console.WriteLine("Added to thr hashtable");
    }

    public void clear()
    {
        employee.Clear();
    }

    public void display()
    {
        Console.WriteLine("\n Displaying hashtable: \n");
        foreach (DictionaryEntry dic in employee)
            Console.WriteLine((string?)dic.Key + " " + dic.Value);
    }
     public void methods()
    {
        Console.WriteLine("Enter a key to check if it exists");
        Console.WriteLine( employee.ContainsKey((string?)Console.ReadLine()) );

        Console.WriteLine($"Number of pairs in Hash-table: {employee.Count}");



    }
}