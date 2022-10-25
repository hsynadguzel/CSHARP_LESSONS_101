using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object veri tipi içerisinde her türlü veri tipini tutabilir.

            object name = "HÜSEYİN";//string
            object number = 36;//int
            object school_number = 3.15;//double
            object control = false;//bool

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(school_number);
            Console.WriteLine(control);
            Console.ReadLine();
        }
    }
}
