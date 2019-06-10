using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class BubbleSort  // O(N2)
    {

        public void BuBBleSort(int[] a)
        {
            for (int i = a.Length-1; i >0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
           

        }
        public  void print(int[] a)
        {
            


            Console.WriteLine("Bubble Sort  array is : ");
            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i]);
                

            }
            Console.ReadKey();

        }
    }
}
