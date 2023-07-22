using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    public class linkedList<T> // generic
    {
        public linkedList(T data)
        {
            Node < T > node = new Node<T> (data);
            this.head = node;
            this.last = node;
        }

        public Node<T> head;
        public Node<T> last;

        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);

            this.last.address = node;
            this.last = this.last.address;
        }

        public void AddFront(T data)
        {
            Node<T> node = new Node<T>(data);

            node.address = head;
            this.head = node;
        }

        public void PrintAll()
        {
            Node<T> node = this.head;
            while(node !=null)
            {
                Console.WriteLine(node.data);
                node = node.address;
            }
        }
    }

    public class Node<T>
    {
        public T data;

        public Node<T> address = null;

        public Node(T data) {
           this.data = data;
        }

    }
}

