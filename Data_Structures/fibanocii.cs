using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures
{
    class fibanocii
    {

        public static void main()
        {
            fib fib = new fib();
            int i =fib.fibc(9);
            Console.Write(i);
            Console.ReadKey();

        }
    }

    class fib
    {
        public int fibc(int n)
        {
            if(n==0)
            {
                return 0;
            }
            else
            {
                int[] f = new int[n + 1];
                int i = 0;
                f[0] = 0;
                f[1] = 1;
                for(i=2;i<=n;i++)
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
                return f[n];

            }


        }

    }
}
