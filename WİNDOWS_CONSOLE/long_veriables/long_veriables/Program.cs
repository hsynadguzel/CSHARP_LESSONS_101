using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long veri tipi -9223372036854775808 ile 9223372036854775807 arasında değer depolayabilir.
            //RAM bellekte 8 byte yer kaplar.

            long first = 54646464;
            long second = 1313554846;

            long minvalue = long.MinValue;
            long maxvalue = long.MaxValue;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine("MİN VALUE = "+minvalue);
            Console.WriteLine("MAX VALUE = "+maxvalue);
            Console.ReadLine();
        }
    }
}
