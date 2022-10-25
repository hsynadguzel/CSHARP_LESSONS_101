using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_indeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu giriniz: ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz: ");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bke = kilo / (boy * boy);
            if (bke < 18)
            {
                Console.WriteLine("Zayıf");
                Console.ReadLine();
            }
            else if(bke > 18 && bke < 25)
            {
                Console.WriteLine("Normal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Obezsiniz");
                Console.ReadLine();
            }
        }
    }
}
