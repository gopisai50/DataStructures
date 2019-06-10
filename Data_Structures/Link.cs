using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class Link
    {


    }

    class nde
    {
        public int item;
        public nde next;
        public nde()
        {
            item = 0;
            next = null;
        }
    }
    class linked
    {
        nde head;
        public linked()
        {
            head = null;
        }

        public void insertfront(int data)
        {
            nde newnode = new nde();
            newnode.item = data;
            nde temp = head;
            if (head.item == 0)
            {
                head = newnode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
        }

        public void insertlast(int data)
        {
            nde newnode = new nde();
            newnode.item = data;
            newnode.next = head.next;
            head = newnode;
        }

        public int deletefront()
        {
            int i = 0;
            nde temp = head;
            if(head.item !=0)
            {
            if(head.next !=null)
            { 
            while(temp.next.next!=null)
            {
                temp = temp.next;
                                
            }
            i = temp.next.item;
            temp.next = null;
            return i;
            }
            else
            {
                i=head.item;
                head = null;
                return i;
            }

            }
            else
            {
                Console.WriteLine("list is empty");
                return i;
            }
        }

        public int  deletelast()
        {
            int i = 0;
            if(head.item==0)
            {
                Console.WriteLine("list is empty");
                return i;
            }
            else
            {
                i = head.item;
                head = head.next;
                return i;
            }

        }

        public void printall()
        {

        }


    }
}
