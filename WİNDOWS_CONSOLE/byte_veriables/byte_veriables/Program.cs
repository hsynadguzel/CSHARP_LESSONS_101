using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte veri tipi 0 - 255 arası tam sayıları tutan veri tipidir.
            byte first = 5;
            byte second = 254;
            byte third = 256;//255'i geçtiği için hata verecektir.

            byte minvalue = byte.MinValue;//byte veri tipinin en düşük değeri.
            byte maxvalue = byte.MaxValue;//byte veri tipinin en büyük değeri.

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

            Console.WriteLine("MİN VALUE = " + minvalue);
            Console.WriteLine("MAX VALUE = " +maxvalue);
            Console.ReadLine();
        }
    }
}
