using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short veri tipi -32768 ile 32767 arasında değer depolayabilir.

            short first = -50;
            short second = 25550;

            short minvalue = short.MinValue;//short veri tipinin en düşük değeri.
            short maxvalue = short.MaxValue;//short veri tipinin en büyük değeri.

            Console.WriteLine(first);
            Console.WriteLine(second);

            Console.WriteLine("MİN VALUE = " + minvalue);
            Console.WriteLine("MAX VALUE = " + maxvalue);
            Console.ReadLine();
        }
    }
}
