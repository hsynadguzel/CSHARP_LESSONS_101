using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1den 10a kadar olan sayılardan çift olanları ekrana yazdıran programı for döngüsü ile yazınız.
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
