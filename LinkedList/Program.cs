using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_LinkedList***");
            Linked_List list = new Linked_List();
            Console.WriteLine("Add_To_Begining");
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
