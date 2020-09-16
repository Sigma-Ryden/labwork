using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value by Om for the transistor R1: ");
            double R1 = 0;
            string str = Console.ReadLine();
            R1 = Convert.ToDouble(str);

            Console.Write("Enter value by Om for the transistor R2: ");
            double R2 = 0;
            str = Console.ReadLine();
            R2 = Convert.ToDouble(str);

            Console.Write("Resistance of R1 and R2 by Om = ");
            Console.WriteLine(R1 * R2 / (R1 + R2));

            Console.ReadLine();
        }
    }
}