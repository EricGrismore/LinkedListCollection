using System;
using System.Text;
using System.Collections.Generic;

public class Christmas
{
    public static void Main()
    {

        string[] christList =
            { "WoddenHorse", "Bicycle", "Laptop", "Headphones", "Cookies", "Mirror" };
        LinkedList<string> winterList = new LinkedList<string>(christList);


        Console.WriteLine("Original friend list");
        foreach (string item in winterList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();



        winterList.AddLast("Pony");
        winterList.AddFirst("Sneakers");




        LinkedListNode<string> targetLocation = winterList.Find("Laptop");
        Console.WriteLine("The next thing on your list after Laptop is {0}", targetLocation.Next.Value);
        Console.WriteLine();


        winterList.AddAfter(targetLocation, "BasballBat");

        winterList.AddBefore(targetLocation, "WinterGloves");

        Console.WriteLine("Other Important Stuff...");



        foreach (string friend in winterList)
        {
            Console.WriteLine(friend);
        }
        Console.WriteLine();
        winterList.RemoveFirst();
        winterList.RemoveLast();
        Console.WriteLine("Things that are not worth it...");
        foreach (string friend in winterList)
        {
            Console.WriteLine(friend);
        }
        Console.WriteLine();





        string[] friendArray = new string[winterList.Count];
        winterList.CopyTo(friendArray, 0);
        Console.WriteLine("friendList is now friendArray");
        foreach (string f in friendArray)
        {
            Console.WriteLine(f);
        }

        winterList.Clear();


    }

}
