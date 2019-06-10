using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class BinarySearch
    {
        public string Search(int[] a, int searchKey)
        {
            String result = "Not found";
            if (a.Length == 1)
            {
                return result;
            }

            if (a[a.Length / 2] == searchKey)
            {
                result = "Found";
                return result;
            }

            int[] l1 = new int[a.Length / 2];
            int[] l2 = new int [a.Length-(a.Length/2)];

            if (searchKey < a[a.Length / 2])
            {
                for (int i = 0; i < a.Length / 2; i++)
                {
                    l1[i] = a[i];
                }

                result = Search(l1, searchKey);
            }
            if (searchKey > a[a.Length / 2])
            {
                for (int i = 0, j = (a.Length / 2) ; j < a.Length; i++, j++)
                {
                    l2[i] = a[j];
                }
                result = Search(l2, searchKey);
            }
            return result;


        }

    }
}
