using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A.2.feladat: bekér két egész számot(𝑎,𝑏), majd kiszámolja a két szám szorzatát és hányadosát2tizedes pontossággal!

namespace gyfel_002
{
    class Program
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("a = ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} * {num2} = {SzamokSzorzata(num1, num2)}");
            Console.WriteLine($"{num1} / {num2} = {SzamokHanyadosa(num1, num2):0.00}");
            Console.ReadKey();
        }

        static int SzamokSzorzata(int a, int b)
        {
            return (a * b);
        }

        static double SzamokHanyadosa(int a, int b)
        {
            return (double) a / b;
        }
    }
}
