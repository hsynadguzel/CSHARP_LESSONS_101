using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int veri tipi -2147483648 ile 2147483647 arasında değer depolayabilir.
            //RAM bellekte 4 byte yer kaplar.

            int first = 15000000;
            int second = 2;

            int minvalue = int.MinValue;//int veri tipinin en küçük değeri.
            int maxvalue = int.MaxValue;//int veri tipinin en büyük değeri.

            Console.WriteLine(first);
            Console.WriteLine(second);

            Console.WriteLine("MİN VALUE"+minvalue);
            Console.WriteLine("MAX VALUE"+maxvalue);
            Console.ReadLine();
             
        }
    }
}
