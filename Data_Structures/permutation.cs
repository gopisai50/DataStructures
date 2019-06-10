using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class permutation
    {
        public static int count = 0;
        public static void Main()
        {
            TimeSpan t = DateTime.Now.TimeOfDay;
            
            string st = "123456789";
            permute(st, 0, st.Length - 1);
            TimeSpan t2 = DateTime.Now.TimeOfDay;
            int actualnumber = fact(st.Length);
            Console.WriteLine(count +"of"+ actualnumber);
            Console.WriteLine("time consumed ="+t2.Subtract(t));
            Console.ReadLine();
        }

        public static int fact(int l)
        {
            if(l==0)
            {
                return 1;
            }
            return l*fact(l - 1);
        }
        public static void permute(string st,int l , int r)
        {

            if(l==r)
            {
                Console.WriteLine(st);
                count++;
            }
            else
            {
                for(int i=l;i<=r;i++)
                {
                    st=swap(st,l, i);
                    permute(st, l + 1, r);
                    st = swap(st, l, i);
                }
            }

        }
        public static string swap(string st,int l,int i)
        {
            char[] a = st.ToCharArray();
            char temp = a[i];
            a[i] = a[l];
            a[l] = temp;

            
            return new String(a);
        }
    }

}
