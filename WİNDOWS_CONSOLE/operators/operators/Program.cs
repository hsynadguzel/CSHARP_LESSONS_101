using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aritmetik
            //Toplma : +
            //Çıkarma : -
            //Çarpma : *
            //Bölme : /
            //Mod alma : %
            //Bir azaltma : --
            //Bir arttırma : ++
            //Atam : =

            //Karşılaştırma
            //Büyük : >
            //Küçük : <
            //Büyük eşit : >=
            //Küçüük eşit : <=
            //Eşit : ==
            //Farklı : != 

            //Mantıksal -> Ve - AND : && , Veya - OR : || , Değil - NOT : !

            int number = 10;
            int number1 = 5;
            int conclusion;

            conclusion = number + number1;
            conclusion = number - number1;
            conclusion = number * number1;
            conclusion = number / number1;
            conclusion = number % number1;
            conclusion = number--;
            conclusion = ++number1;
            Console.WriteLine(conclusion);
            Console.ReadLine(); 


        }
    }
}
