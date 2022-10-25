using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long veri tipi -3,402823E+38 ile 3,402823E+38 arasında değer depolayabilir.
            //RAM bellekte 8 byte yer kaplar.

            float first = 1.2131564f;//değişkenin sonuna "f" harfi koymak zorundayız yoksa double veri tipi olarak algılar.
            float second = 5.596f;

            float minvalue = float.MinValue;
            float maxvalue = float.MaxValue;

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine("MİN VALUE = "+minvalue);
            Console.WriteLine("MAX VALUE = "+maxvalue);
            Console.ReadLine();
        }
    }
}
