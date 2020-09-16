using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for nk");
            Console.WriteLine("where nk is natural number");

            int nk = 0;

            do
            {
                Console.Write("nk: ");

                string str = Console.ReadLine();
                nk = Convert.ToInt32(str);

                if (nk < 0)
                {
                    Console.WriteLine("Put the correct value!");
                }

            } while (nk < 0);

            Console.WriteLine("Enter the value for nn");
            Console.WriteLine("where nn is natural number and nn => nk");

            int nn = 0;

            do
            {
                Console.Write("nn: ");

                string str = Console.ReadLine();
                nn = Convert.ToInt32(str);

                if (nn < nk)
                {
                    Console.WriteLine("Put the correct value!");
                }

            } while (nn < nk);

            double sum = 0;

            for (int k = nk; k <= nn; k++)
            {
                sum += (k * k - 1) / (Math.Pow(-1, k + 1) * k * k + 7);
            }

            Console.Write($"Sum of the series from {nk} to {nn} = {sum}");
            Console.ReadLine();
        }
    }
}