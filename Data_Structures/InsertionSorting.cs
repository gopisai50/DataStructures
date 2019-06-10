using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class InsertionSorting
    {
        public int[] InsertionSort(int[] a)
        {
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    int temp = a[i+1];
                    a[i+1] = a[i];
                    a[i] = temp;
                    check(a, i);
                }
            }

            return a;
        }
        public void check(int[] a, int i)
        {
            if (i == 0)
            {
                return;
            }

            if (a[i] < a[i - 1])
            {
                int temp = a[i - 1];
                a[i - 1] = a[i];
                a[i] = temp;
                check(a, i-1);

            }

        }
        public void print(int[] a)
        {
            Console.WriteLine("Insertion Sort  array is : ");
            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i]);

            }
            Console.ReadKey();

        }
    }
}
