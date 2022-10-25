using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //doble veri tipi 15 basamaklı ondalıklı sayılar tutulabilir.
            //RAM bellekte 8 byte yer kaplar.

            double first = 36.596;
            double second = -36.06;

            double minvalue = double.MinValue;
            double maxvalue = double.MaxValue;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine("MİN VALUE = "+minvalue);
            Console.WriteLine("MAX VALUE = "+maxvalue);
            Console.ReadLine();
        }
    }
}
