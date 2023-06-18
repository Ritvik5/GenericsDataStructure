using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDataStructures
{
    public class BuiltInQueue
    {
        Queue<int> queue = new Queue<int>();

        public void Display()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is Empty.");
                return;
            }
            foreach (var item in queue)
            {
                Console.Write("| "+item+" |");
            }
        }
        public void CrudOperation3()
        {
            Console.WriteLine("After elements in Queue: \n");
            queue.Enqueue(100);
            queue.Enqueue(110);
            queue.Enqueue(125);
            queue.Enqueue(154);
            Display();

            Console.WriteLine("\nElement in front is: "+ queue.Peek() + "\n");

            queue.Dequeue();

            Console.WriteLine("\nAfter removing the elements from the front: \n");
            Display();

            Console.WriteLine("\nAfter deleting all the elements in queue: \n");
            queue.Clear();
            Display();

        }
    }
}
