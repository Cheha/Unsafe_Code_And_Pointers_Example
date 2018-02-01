using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5_Struct
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            MySize msz;
            MySize* ptr = &msz;

            ptr->MyWidth = 300;
            ptr->MyHeight = 100;

            Console.WriteLine("\r\nStructure via pointers");
            Console.WriteLine("{0} {1}", ptr->MyWidth, ptr->MyHeight);
            Console.WriteLine("Structure ");
            Console.WriteLine("{0} {1}", msz.MyWidth, msz.MyHeight);

            MySize msz2;
            MySize* ptr2 = &msz2;
            (*ptr2).MyWidth = 300;
            (*ptr2).MyHeight = 100;

            Console.WriteLine("Structure via pointers indirection");
            Console.WriteLine("{0} {1}", msz2.MyWidth.ToString(), msz2.MyHeight.ToString());

            Console.ReadLine();
        }

        struct MySize
        {
            public int MyWidth;
            public int MyHeight;
        }
    }
}
