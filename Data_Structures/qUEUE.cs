using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class qUEUE
    {
        private int front = 0;
        private int rear = -1;
        static readonly int max = 3;
        public int[] queu = new int[max];

        public bool isEmpty()
        {
            if (rear == front - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int peek()
        {
            if (!isEmpty())
            {
                return queu[front];
            }
            else
            {
                Console.WriteLine("queue is empty");
                return 0;
            }
        }

        public bool enqueue(int data)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("queue is full");
                return false;
            }
            else
            {
                queu[++rear] = data;
                return true;
            }
        }
        public int dequeue()
        {
            if (!isEmpty())
            {
                return queu[front++];
            }
            else
            {
                Console.WriteLine("que is empty");
                return 0;
            }
        }


    }

    class test1
    {
        //public static void Main()
        //{
        //    qUEUE q = new qUEUE();
        //   bool t= q.enqueue(5);
        //   t = q.enqueue(5);
        //    t = q.enqueue(5);
        //    t = q.enqueue(5);
        //    int i =q.dequeue();
        //    i= q.dequeue();
        //    i = q.dequeue();
        //    i = q.dequeue();
        //}
    }
}
