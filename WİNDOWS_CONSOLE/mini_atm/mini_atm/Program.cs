using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM'ye Hoşgeldiniz...");
            Console.WriteLine("Lütfen İşlem Seçiniz");
            Console.WriteLine("1_Bakiye Görüntüle");
            Console.WriteLine("2_Para Çek");
            Console.WriteLine("3_Para Yatır");
            Console.WriteLine("4_Çıkış Yap");
            int bakiye = 7000;
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz : "+bakiye);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.WriteLine("Çekmek İstediğini Tutarı Giriniz : ");
                    int p_cek =Convert.ToInt32(Console.ReadLine());
                    if (p_cek>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz !");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz : " + (bakiye - p_cek));
                        Console.ReadLine();
                    }                    
                    break;
                case "3":
                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz : ");
                    int p_ytr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncel Bakiyeniz : "+(bakiye+p_ytr));
                    Console.ReadLine();
                    break ;
                case "4":
                    Console.WriteLine("Çıkış Yapıyorsunuz !!");
                    Console.WriteLine("İyi Günler Dileriz");
                    Console.ReadLine();
                    break ;
                default:
                    Console.WriteLine("Hatalı Giriş Yaptınız !");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
