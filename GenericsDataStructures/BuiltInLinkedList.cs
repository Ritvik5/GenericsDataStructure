using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDataStructures
{
    public class BuiltInLinkedList
    {
        LinkedList<int> list = new LinkedList<int>();


        public void Display()
        {
            if(list.Count == 0)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }
        }
        public void CrudOperations()
        {
            Console.WriteLine("Adding elements in LinkedList : \n");
            list.AddFirst(70);
            list.AddFirst(50);
            list.AddFirst(60);
            list.AddFirst(80);
            Display();
            Console.WriteLine("\nAfter removing first and last elements: \n");
            list.RemoveLast();

            list.RemoveFirst();
            Display();

            Console.WriteLine("\nAfter Inserting element at first and last position: \n");
            list.AddFirst(1000);
            list.AddLast(2000);
            Display();

            Console.WriteLine("\nAfter deleting all elements :\n");
            list.Clear();
            Display();
        }
    }
}
