using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //num.WriteNum(a, b);
            num.WriteSum(a, b);
            Console.WriteLine("hi");



            Console.ReadKey();
        }
    }
}
