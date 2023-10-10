using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; int b = 2;
            Console.WriteLine("le calculator 3000 ");

            Console.WriteLine("-------------------");

           a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("donnez moi un chiffre" + a);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
