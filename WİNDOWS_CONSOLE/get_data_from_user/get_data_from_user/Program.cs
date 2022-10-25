using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_data_from_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read.Lİne(); methodu ile kullanıcadan değer alınır.
            Console.WriteLine("LÜTFEN İSİM GİRİNİZ : ");
            string name = Console.ReadLine();
            Console.WriteLine("LÜTFEN SOYİSMİNİZİ GİRİNİZ : ");
            string surname = Console.ReadLine();
            Console.WriteLine("HOSŞGELDİN "+name+" "+surname);
            Console.ReadLine();
        }
    }
}
