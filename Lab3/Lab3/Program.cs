using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter any natural number: ");

            int a = 0;
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);

            if (a > 9 && a < 100 && a % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();

        }
    }
}
