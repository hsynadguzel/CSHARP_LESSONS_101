using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exp_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char karakter = 'a'; karakter <= 'z'; karakter++)
            {
                Console.WriteLine(karakter);
            }
            Console.ReadLine(); 
        }
    }
}
