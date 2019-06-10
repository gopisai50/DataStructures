using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
     class Stack
    {

        private static readonly int max = 1000;
          public int top = -1;
         int[] stac = new int[max];
        bool isEmpty()
        {

            return (top < 0);
        }
        public bool push(int data)
        {
            if (top != max)
            {
                stac[++top] = data;
                return true;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
                return false; 

            }
        }
        public int pop()
        {
            if (top >= 0)
            {
                return stac[top--];
            }
            else
            {
                Console.WriteLine("Stack empty");
                return 0;

            }
        }
        public int peek()
        {
            if (top >= 0)
            {
                return stac[top];
            }
            else
            {
                Console.WriteLine("Stack empty");
                return 0;

            }

        }

        public void printStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;

            }
            else
            {
                Console.WriteLine("stack elements are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stac[i]);
                }
            }

        }

     }

    public class test
    {
        //public static void Main(string [] args)
        //{

        //    Stack st = new Stack();
        //    int d = st.top;
        //    st.push(5);
        //    st.push(2);
        //    st.push(6);
        //    st.push(7);
        //    st.push(1); 
        //    st.push(9);
        //    int i =st.peek();
        //    int j = st.pop();
        //    int k = st.peek();
        //}
        
    }
}
