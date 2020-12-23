using System;
using System.Globalization;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            arr.ShowArrayReverse();

            Console.ReadLine();
        }        
    }
    public static class Extention
    {
       public static int IntReverse(this int oldNumber)
        {
            int newNumber = 0;
            while (oldNumber > 0)
            {
                int temp = oldNumber % 10;
                newNumber = (newNumber * 10) + temp;
                oldNumber = oldNumber / 10;
            }
            return newNumber;
        }


        public static string StringReverse(this string oldString)
        {
            string newString = "";
            for (int i = oldString.Length - 1; i >= 0; i--)
            {
                newString += oldString[i];
            }
            return newString;
        }


        public static string PointStringReverse(this string oldString)
        {
            string newString = "";
            var strings = oldString.Split(',');

            for (int i = 0; i < strings.Length - 1; i++)
            {
                newString += StringReverse(strings[i]) + ',';
            }
            newString += StringReverse(strings[strings.Length - 1]);
            return newString;
        }

        public static double SplitReverse(this double value)
            => Double.Parse(SplitReverse(value.ToString(CultureInfo.CurrentCulture)));
        private static string SplitReverse(string v)
        {
            throw new NotImplementedException();
        }
        public static T[] Reverse<T>(this T[] array)
        {
            T[] newArray = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newArray[i] = array[j];
            }
            return newArray;
        }

        public static void ShowArrayReverse(this int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
