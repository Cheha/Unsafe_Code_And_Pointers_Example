using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Pointers
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int* a; // define pointer
            int b = 8;
            a = &b;
            Console.WriteLine(*a);
            Console.WriteLine(b);
            Console.WriteLine("Address of b {0:X}", (int)a);
            b = b + 8;
            Console.WriteLine(*a);
            *a = 2;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
