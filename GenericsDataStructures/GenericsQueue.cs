using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenericsDataStructures
{
    public class GenericsQueue<T>
    {
        public Node<T> front;
        public Node<T> rear;
        private void IfFromntIsNull()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty!!!");
            }
        }

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);

            if (this.rear == null)
            {
                this.rear = this.front = node;
            }
            else
            {
                this.rear.next = node;
                this.rear = node;
            }
            Console.WriteLine("{0} is inserted in the list", data);
        }

        public void Display()
        {
            Node<T> temp = front;
            IfFromntIsNull();
            while (temp != null)
            {
                Console.Write(temp.data + " | ");
                temp = temp.next;
            }
        }
    }
}
