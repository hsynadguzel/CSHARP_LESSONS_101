using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_exp_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan 10 adet isim alarak başlarına da numaralarını yazan kodu for döngüsü ile yazınız
            string name;
            for (int i = 1 ; i < 11; i++)
            {
                Console.WriteLine(i + ".İsmi Gieiniz :");
                name = Console.ReadLine();
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
