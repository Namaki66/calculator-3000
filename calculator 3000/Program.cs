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
            //
            int a, b;


            Console.WriteLine("le calculator 3000 ");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("ecrivez votre premier chifre ");
           a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("et mnt le deuxieme");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choisisez votre operation ");
            Console.WriteLine("(+) (-) (*) (/)");


          
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
