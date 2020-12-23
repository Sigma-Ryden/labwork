using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            arr.ArrayReverse();

            Console.ReadLine();
        }        
    }
    public static class ArrayExtention
    {
        public static void ArrayReverse(this int[] arr)
        {
            for (int i = arr.Length - 1; i >=  0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
