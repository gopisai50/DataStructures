﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class Program
    {

        //static void Main(string[] args)
        //{

        //    int[] a = new int[] { 66, 77, 88, 99, 55, 44, 33, 22, 11, 89, 09, 78, 67, 56, 4, 53, 32, 23, 56, 78, 4, 35, 7, 89, 4, 3, 4, 67, 7, 4, 4, 76, 87, 5, 4, 3, 5, 7, 78, 9 };
        //    //BubbleSort bbsort = new BubbleSort();
        //    InsertionSorting bbsort = new InsertionSorting();
        //    //SelectionSorting bbsort = new SelectionSorting();
        //    // MergeSorting bbsort = new MergeSorting();
        //    bbsort.print(a);
        //    bbsort.InsertionSort(a);
        //    bbsort.print(a);

        //}

        //static void Main(string[] args)
        //{

        //    int[] a = new int[] { 88, 66, 778 };
        //    MergeSorting Sort = new MergeSorting();
        //    a = Sort.MergeSort(a);
        //    int searchKey = Convert.ToInt32(Console.ReadLine());
        //    //LinearSearch linearsearch = new LinearSearch();
        //    BinarySearch binarySearch = new BinarySearch();
        //    string result = binarySearch.Search(a, searchKey);
        //    Console.WriteLine(result);
        //    Console.Read();

        //}

        static void Main(string[] args)
        {
            linkedList<string> li = new linkedList<string>("Gopi");
            li.AddLast("sandhya");
            li.AddFront("Something1");
            li.AddFront("Something2");
            li.AddLast("Something3");
            li.AddLast("Something4");
            li.PrintAll();

            linkedList<int> li2 = new linkedList<int>(1);
            li2.AddLast(2);
            li2.AddFront(2);
            li2.AddFront(7);
            li2.AddLast(6);
            li2.AddLast(5);
            li2.PrintAll();
        }

    }
}
