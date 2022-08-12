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
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
