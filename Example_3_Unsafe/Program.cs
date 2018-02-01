using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_Unsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            UnsafeSum();
            Console.ReadLine();
        }

        public unsafe static void UnsafeSum()
        {
            Console.WriteLine("Unsafe sum 100 + 10");
            int a = 10;
            int b = 100;
            int* mySum = SumByPointers(&a, &b);
            Console.WriteLine(*mySum);
        }

        public unsafe static int* SumByPointers(int* a, int* b)
        {
            int mysum;
            mysum = *a + *b;
            return &mysum;
        }
    }
}
