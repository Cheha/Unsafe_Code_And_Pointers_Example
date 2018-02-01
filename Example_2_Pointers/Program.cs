using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Pointers
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            Console.WriteLine("Calling method with unsafe code");
            // Window for rotate
            int w = 10, h = 20;
            // Rotate window "safely"
            Console.WriteLine("\r\nSafe rotate");
            Console.WriteLine("Window before safe rotate: width = {0}, height = {1}",w, h);
            SafeRotate(ref w, ref h);
            Console.WriteLine("Window after safe Rotate: width = {0}, height = {1}",w, h);
            // Rotate window "unsafely"
            Console.WriteLine("\r\nUnsafe Rotate");
            Console.WriteLine("Window before unsafe Rotate: width = {0}, height ={1}", w, h);
            unsafe { UnsafeRotate(&w, &h); }
            Console.WriteLine("Window after unsafe Rotate: width = {0}, height = {1}",w, h);
            Console.ReadLine();
        }
        
        unsafe public static void UnsafeRotate( int* i, int* j )
        {
            int temp = *i;
            *i = *j;
            *j = temp;
        }
        
        
        public static void SafeRotate(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }
}
