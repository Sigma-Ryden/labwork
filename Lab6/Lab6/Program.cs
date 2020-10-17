using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        /*
        static void InvertNumber(int a)
        {
            do
            {
                Console.Write(a % 10);
                a /= 10;
            }
            while (a > 0);
        }
        */
        static void InvertString(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        static void InvertStringPoint(string str)
        {
            int j = 0;

            while (str[j] != ',')
            {
               j++;
            }

            for (int i = j - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.Write(str[j]);
            for(int i = str.Length - 1; i > j; i--)
            {
                Console.Write(str[i]);
            }

        }

    }
}
