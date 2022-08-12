using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_LinkedList***");
            Linked_List list = new Linked_List();
            list.Add(56);
            list.Add(70);
            list.Display();
            Console.WriteLine("\nAfter Inserting Element...");
            list.InserAtParticularPosition(2, 30);
            list.Display();
            Console.WriteLine("\nAfter Deleting First Node");
            list.RemoveFirstNode();
            list.Display();
            Console.ReadLine();
        }
    }
}
