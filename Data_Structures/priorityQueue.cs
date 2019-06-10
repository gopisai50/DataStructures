using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class priorityQueue
    {
        //public static void Main()
        //{
        //    prioritylinkedlist pl = new prioritylinkedlist();
        //    pl.enqueue(1, 1);
        //    pl.enqueue(2, 9);
        //    pl.enqueue(3, 10);
        //    pl.enqueue(4, 5);
        //    int i =pl.dequeue();
        //    i =pl.peek();
        //}
    }

    public class node
    {
        public int item;
        public int priority;
        public node next;
        public node()
        {
            priority = 0;
            item = 0;
            next = null;
        }
    }

    public class prioritylinkedlist
    {
        public node head = new node();
        public void enqueue(int data, int p)
        {
            node newnode = new node();
            newnode.item = data;
            newnode.priority = p;
            if (head.item == 0)
            {
                head = newnode;
                return;
            }
            if (head.priority < p)
            {
                newnode.next = head;
                head = newnode;
            }
            else
            {
                node temp = new node();
                temp = head;
                while (temp.next != null)
                {
                    if (temp.next.priority > p)
                        temp = temp.next;
                    else
                    {
                        break;
                    }
                }

                newnode.next = temp.next;
                temp.next = newnode;
            }
        }

        public int dequeue()
        {
            int i = head.item;
            head = head.next;
            return i;
        }


        public int peek()
        {
            return head.item;
        }
    }
}
