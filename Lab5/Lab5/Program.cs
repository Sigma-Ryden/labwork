using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of arr n x m:");

            int n = 0;

            do
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Enter the natural number!");
                }

            } while (n < 0);

            int m = 0;
            do
            {
                Console.Write("m = "); 
                m = Convert.ToInt32(Console.ReadLine());

                if (m < 0)
                {
                    Console.WriteLine("Enter the natural number!");
                }

            } while (m < 0);

            Console.WriteLine();

            int[,] arr = new int[n, m];

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"a{i}{j} = ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine()); 
                }
            }

            Console.WriteLine();
            Console.WriteLine("Before replacing of max and min number in each row of the arr:");
            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = 0;
                int min = 0;
                int temp = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i, j] < arr[i, min])
                    {
                        min = j;
                    }
                    if(arr[i, j] > arr[i, max])
                    {
                        max = j;
                    }
                }

                temp = arr[i, min];
                arr[i, min] = arr[i, max];
                arr[i, max] = temp;
            }
            
            Console.WriteLine("After replacing of min and max number in each row of the arr:");
            Console.WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}