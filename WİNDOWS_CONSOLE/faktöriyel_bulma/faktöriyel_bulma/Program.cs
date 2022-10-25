using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktöriyel_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int i = sayi; i > 1; i--)
            {
                sonuc *= i;
            }
            Console.WriteLine("Faktöriyel = "+sonuc);
            Console.ReadLine();
        }
    }
}
