using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_6_stackallock
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                char* ptr = stackalloc char[256];
                for (int i = 0; i < 257; i++)
                {
                    ptr[i] = (char)i;
                    Console.WriteLine("{0}    {1}", i, ptr[i]);
                }
                Console.ReadLine();
            }
            Console.WriteLine();
        }
    }
}
