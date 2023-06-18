using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDataStructures
{
    public class BuiltInStack
    {
        Stack<int> stack = new Stack<int>();

        public void Display()
        {
            if(stack.Count == 0)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            foreach(int i in stack)
            {
                Console.WriteLine("| "+i+" | ");
            }
        }

        public void CrudOperation1()
        {
            Console.WriteLine("Adding elements in Stack: \n");
            stack.Push(100);
            stack.Push(101);
            stack.Push(102);
            stack.Push(103);
            Display();

            Console.WriteLine("\nAfter removing top element in the stack: \n");
            stack.Pop();
            Display();

            Console.WriteLine("\nElement on top is: "+stack.Peek());

            Console.WriteLine("\nTotal number of elelment in stack are: "+stack.Count+"\n");

            Console.WriteLine("\nAfter deleting all elements of the stack: \n");
            stack.Clear();
            Display();
        }
    }
}
