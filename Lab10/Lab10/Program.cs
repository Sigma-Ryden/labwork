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

        public static string RecurseRever( this string s)
        {
            if (s.Length <= 0)
            {
                return s;
            }
            else
            {
                return s[s.Length - 1] + RecurseRever(s.Substring(0, s.Length - 1));
            }
        }
        public static double DoubleReverse(this double val) => Double.Parse(DoubleReverse(val.ToString()));
        public static string DoubleReverse(this string val)
        {
            string reverse = string.Empty;
            var strings = val.Split(',');
            for (int i = 0; i < strings.Length - 1; i++)
            {
                reverse += RecurseRever(strings[i]) + ',';
            }
            reverse += RecurseRever(strings[strings.Length - 1]);
            return reverse;
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
