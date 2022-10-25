using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exp_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan aldığı 10 adet sayıyı toplayan programı for döngüsü ile yazınız 
            double toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + ".Sayıyı girinirz : ");
                double sayı = Convert.ToDouble(Console.ReadLine());
                toplam += sayı;
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
