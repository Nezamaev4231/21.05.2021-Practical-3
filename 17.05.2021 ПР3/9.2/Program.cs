using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.1 пр3
       
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while(n!= 0)

            {
                int a = n % 10;
                if (a == 3)
                {
                    k++;
                }
                n = n / 10;
            }
            if (k == 0)
            {
                Console.WriteLine("нет");
            }
            else
            {
                Console.WriteLine("да");
            }
            Console.ReadKey();


           
        }
    }
}
