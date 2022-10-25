using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop_exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı=100;
            /*while (sayı < 10)
            {
                Console.WriteLine(sayı);
                sayı++;
            }*/
            while (sayı >= 0)
            {
                Console.WriteLine(sayı);
                sayı -= 2; // a= a-2;
            }
            Console.ReadLine();
        }
    }
}
