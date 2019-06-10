using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class LinearSearch
    {
        public string Search(int [] a , int searchKey)
        {
            string result = "Not Found";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == searchKey)
                {
                    result = "Found";
                }
            }

            return result;

        }

    }
}
