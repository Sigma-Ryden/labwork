using System;

namespace Lab6_update_
{
    class Program
    {
        public static int IntReverse(int oldNumber)
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

        //
        static string RecurseRever(string s)
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
        static double DoubleReverse(double val) => Double.Parse(DoubleReverse(val.ToString()));
        static string DoubleReverse(string val)
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
        //

        public static string StringReverse(string oldString)
        {
            string newString = "";
            for (int i = oldString.Length - 1; i >= 0; i--)
            {
                newString += oldString[i];
            }
            return newString;
        }
        public static string PointStringReverse(string oldString)
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

        static int IntRecursionReverse(int value, int rever = 0)
        {
            if (value == 0)
            {
                return rever;
            }
            int remainded = value % 10;
            rever = (rever * 10) + remainded;

            return IntRecursionReverse(value / 10, rever);
        }

        static T[] Reverse<T>(T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newArr[i] = array[j];
            }
            return newArr;
        }

        static void Reverse<T>(ref T[] array)
        {
            T[] newArr = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newArr[i] = array[j];
            }
            array = newArr;
        }

        static void Reverse<T>(T[] array, out T[] newArray)
        {
            newArray = new T[array.Length];
            for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
            {
                newArray[i] = array[j];
            }
        }

        static void Main(string[] args)
        {
            int a = 1234;
            string str = "ABCD";
            double b = 1234.5678;
            string str_lips = "ABCD,EFGH";

            Console.WriteLine(IntReverse(a));
            Console.WriteLine(DoubleReverse(b));
            Console.WriteLine(StringReverse(str));
            Console.WriteLine(PointStringReverse(str_lips));

            Console.ReadLine();
        }
    }
}