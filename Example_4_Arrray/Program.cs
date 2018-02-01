using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4_Arrray
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            unsafe {
                int[] num = new int[7];
                Console.WriteLine("Indexing pointer as array");
                fixed (int* ptr = num)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        ptr[i] = i;
                        Console.WriteLine("ptr[{0}]: {1} ", i, ptr[i]);
                    }
                }
                Console.WriteLine("\r\nArithmetic operations with pointers");
                fixed (int* ptr = num)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        *(ptr + i) = i;
                        Console.WriteLine("*(ptr+{0}): {1} ", i, *(ptr + i));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
