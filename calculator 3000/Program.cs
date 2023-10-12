using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_3000
{
    internal class Program
    {

        public static int add(int a, int b)
        { return a + b; }
        public static int sus(int a, int b)
        { return a - b; }
        public static int fois(int a, int b)
        { return a * b; }
        public static int divi(int a, int b)
        { return a / b; }
        static void Main(string[] args)
        {
            // les variaable
            int a;
            int b;
            char op;
            // le code pour les question

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
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(add(a , b)); 
                   // Console.WriteLine(a + b);
                    break;


                case '-':
                    Console.WriteLine(sus(a , b));
                   // Console.WriteLine(a - b);
                    break;

                case '*':
                    Console.WriteLine(fois(a , b));
                   // Console.WriteLine(a * b);
                    break;

                case '/':
                    Console.WriteLine(divi(a , b));
                   // Console.WriteLine(a / b);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;  
            }

            {




                Console.ReadKey();


            }
        }
    }
}