using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 7, 23, 12 };
            int[] b = { -4, -6, 89, 6 };
            int s = 0;

            Console.Write("\n[");
            for (int i = 0; i < a.Length; i++)
            {
                if (i < a.Length - 1)
                    Console.Write("{0}, ", a[i]);
                else
                    Console.Write("{0}", a[i]);
                if (i % 2 != 0) s += a[i];
            }
            Console.WriteLine("] -> {0}", s);
            
            s = 0;
            Console.Write("\n[");
            for (int i = 0; i < b.Length; i++)
            {
                if (i < b.Length - 1)
                    Console.Write("{0}, ", b[i]);
                else
                    Console.Write("{0}", b[i]);
                if (i % 2 != 0) s += b[i];
            }
            Console.WriteLine("] -> {0}", s);

            Console.ReadKey();
        }
    }
}
