namespace GenericsDataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Data Structures!!!\n");

            //-- Generics Linked List

            //GenericsLinkedList<int> list = new GenericsLinkedList<int>();

            //list.Add(56);
            //list.Add(30);
            //list.Add(70);

            //list.Display();

            //-- Generics Stack

            //GenericsStack<int> stack = new GenericsStack<int>();
            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);
            //stack.Display();

            //--Generics Queue

            //GenericsQueue<int> obj = new GenericsQueue<int>();

            //obj.Enqueue(56);
            //obj.Enqueue(30);
            //obj.Enqueue(70);
            //obj.Display();

            //--CRUD Operations on Linked List

            //BuiltInLinkedList obj = new BuiltInLinkedList();

            //obj.CrudOperations();

            //--CRUD Operation on Stack

            //BuiltInStack obj = new BuiltInStack();
            //obj.CrudOperation1();

            //--CRUD Operation on Queue

            BuiltInQueue obj = new BuiltInQueue();
            obj.CrudOperation3();
        }
    }
}