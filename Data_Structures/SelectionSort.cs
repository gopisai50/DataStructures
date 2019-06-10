using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class SelectionSorting
    {

        public void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int j=findmin(i,a);
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }

        public int findmin(int i, int[] a)
        {
            int temp = i;
            for(int j =i+1 ; j<a.Length;j++)
            {
                if (a[temp] > a[j])
                {
                    temp = j;
                }
            }
            return temp;
        }

        public void print(int[] a)
        {
            
            Console.WriteLine("Selection Sort  array is : ");
            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i]);

            }
            Console.ReadKey();

        }
    }
}
