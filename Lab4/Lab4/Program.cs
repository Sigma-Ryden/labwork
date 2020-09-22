using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the arr:");
            
            int  n = 0;

            do
            {
                Console.Write("n = ");

                n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Enter the natural number!");
                }

            } while (n < 0);

            int[] arr = new int[n];

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"a{i} = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Even numbers of given arr: ");

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] %2 == 0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.WriteLine();
            Console.Write("Odd numbers of given arr: ");

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] %2 != 0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.ReadLine();
        }
    }
}
