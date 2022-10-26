using System.Collections;

public class ArrayListEx
{
    ArrayList arrayList = new ArrayList()
    {
        101,
        "James",
        true,
        10.20
    };

    public void display()
    {
        foreach (var i in arrayList)
            Console.WriteLine(" " + i);
    }
    public void add(object inp)
    {
        //var inp = Console.ReadLine();
        arrayList.Add(inp);
    }

    public void insert()
    {
        arrayList.Insert(0, "First Element");

        arrayList.Insert(2, "Third Element");

        Console.WriteLine("After insertion: ");
        foreach (var item in arrayList)
        {
            Console.WriteLine($"{item}");
        }
        Console.ReadKey();
    }

    public void insertRange()
    {
        ArrayList arrayList2 = new ArrayList()
            {
                    "Srilanka",
                    "Japan",
                    "Britem"
            };
        arrayList.InsertRange(2, arrayList2);

        Console.WriteLine("\n\nArray List Elements After InsertRange");
        foreach (var item in arrayList)
        { 
            Console.Write($"{item} ");
        }
        Console.ReadKey();
    }
}