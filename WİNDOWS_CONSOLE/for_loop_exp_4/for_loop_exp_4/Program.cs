using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exp_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen 10 adet sayıdan pozitif ve tek olan sayıların çarpını yazdıran for döngüsünü yazınız.
            int sayı, sonuc = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}.Sayıyı giriniz : ",i);
                sayı= Convert.ToInt32(Console.ReadLine());
                if ((sayı > 0) && (sayı %2 == 1))
                {
                    sonuc *= sayı;
                }
                Console.WriteLine();
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
