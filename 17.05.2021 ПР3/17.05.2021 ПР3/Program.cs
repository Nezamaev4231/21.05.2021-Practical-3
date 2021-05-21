using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._05._2021_ПР3
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.2

            Console.WriteLine("Введите x");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k");
            double k = Convert.ToInt32(Console.ReadLine());

            double y = 0;
            if (k < x)
            {
               y= k * x;
            }
            else
            {
                y = k + x;
            }
            Console.WriteLine("y="+y);
            Console.ReadKey();
           

        }
    }
}
