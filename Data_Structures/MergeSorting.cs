using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class MergeSorting
    {
        #region

        // public int []  MergeSort(int [] a)
       // {
       //    a=divide(a);
       //    return a;
           
          
       // }

       // public int [] divide(int [] a)
       //{
           
           
       //    int low = 0;
       //    int medium = a.Length / 2 + 1;
       //    int high = a.Length;

       //     if(a.Length == 1)
       //     {
       //         return a;
       //     }
            
       //     int[] l1 =new int [a.Length/2]; 
       //     int[] l2 = new int[a.Length-a.Length /2];
       //     int []l3 = new int[a.Length];
       //     for (int i = 0; i < a.Length / 2; i++)
       //     {
       //         l1[i] = a[i];
       //     }

       //     for (int j = 0,i = a.Length/2; i <= a.Length ; i++,j++)
       //     {
       //         l2[j] = a[i];
       //     }

       //     l1 = divide(l1);
       //     l2 = divide(l2);
       //     l3= Merge(l1, l2, low, medium, high);
       //     return l3;
       //}

       // public int[] Merge(int [] l1,int [] l2,int low ,int medium,int high)
       // {
       //     low = 0;
       //     medium = 0;
       //     int l = low;
       //     int m =l1.Length;
       //     int h= l2.Length;
       //     int[] l3 = new int[l1.Length + l2.Length];
       //     int i = 0;
       //     while (low< m && medium< h)
       //     {
                
       //         if (l1[low] < l2[medium])
       //         {
       //             l3[i] = l1[low++];

       //         }
       //         else
       //         {
       //             l3[i] = l2[medium++];
       //         }
       //         i++;
       //     }

       //     while (low < m)
       //     {
       //         l3[i++] = l1[low++];
       //     }

       //     while (medium < h)
       //     {
       //         l3[i++] = l2[medium++];
       //     }
       //     return l3;
       // }
       // public void print(int[] a)
       // {

       //     Console.WriteLine("Merge Sort  array is : ");
       //     for (int i = 0; i < a.Length; i++)
       //     {

       //         Console.WriteLine(a[i]);

       //     }
       //     Console.ReadKey();

        // }

        #endregion


        
        public static void main()
        {
            mergedemo demo = new mergedemo();

            int[] a = new int[] { 5, 8, 4 };
            demo.merging(a,0,a.Length-1);
            Console.ReadKey();
        }


    }

    class mergedemo
    {

        public void merging(int [] a,int p,int q)
        {
            if(p>q)
            {
                return;
            }
            else{

                int mid =(p+q)/2;
                merging(a ,p,mid-1);
               merging(a,mid+1,q);
               merge(a,p,mid+1,q);

            }
        }

        public void merge(int []ar,int a,int mid,int b)
        {
            int cur = mid - 1;
            int [] c= new int[25 ];
            int low=a;
            int high =b;
            int i=0;
            while(low<=cur&mid<=b)
            {
                if(ar[low]<ar[mid])
                {
                    c[i++]=ar[low++];

                }
                else
                {
                    c[i++]=ar[mid++];
                }

            }
            while(low<=cur)
            {
                c[i++]=ar[low++];
            }
            while(mid<=b)
            {
                c[i++]=ar[mid++];
            }
            int num = b - a + 1;
            for (int k = 0; k < num; k++)
            {
               ar[b] = c[b];
               b--;
            }


        }
    }
}
