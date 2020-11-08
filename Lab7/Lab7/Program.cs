using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void FillArray(List<double> list, in int SIZE)
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("list[{0}]: ", i + 1);
                list.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        static void ShowValueIndex(List<double> list, in double val)
        {
            bool flag = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == val)
                {
                    Console.WriteLine("{0} from {1} position", list[i], i + 1);
                    flag = true;
                }
                else
                {
                    continue;
                }
            }

            if(flag)
            {
                Console.WriteLine("Operation has been successful");
            }
            else
            {
                Console.WriteLine("The search didn't return any result");
            }
        }

        static void CopyToArray(double[] arr, List<double> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                arr[i] = list[i];
            }
        }
        static void ShowArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}]: {1}", i, arr[i]);
            }
        }
        static void Main(string[] args)
        {
            List<double> list = new List<double>();

            Console.Write("Enter ths size of List: ");
            int SIZE = Convert.ToInt32(Console.ReadLine());

            FillArray(list, SIZE);
            
            Console.Write("Enter the value for searching index of list: ");
            int n = Convert.ToInt32(Console.ReadLine());

            ShowValueIndex(list, n);

            double[] arr = new double[SIZE];

            CopyToArray(arr, list);
            ShowArray(arr);

            Console.ReadLine();
        }
    }
}