using System;
using System.Collections.Generic;


namespace individualWork
{
    class Cars
    {
        public List<string> Colors = new List<string>();
        public int Year;
        public int Price;
        public string Model;
        public int Choice;

        public void ErrorInfo()
        {
            Console.WriteLine("Error. Try again: ");
        }

        public void InputInfo()
        {
            int numberColors = 0;
            while (true)
            {
                Console.Write("Number of car colors: ");
                if (!int.TryParse(Console.ReadLine(), out numberColors) || numberColors < 0) ErrorInfo();
                else break;
            }

            for (int i = 0; i < numberColors; i++)
            {
                Console.Write($"Color {i + 1}: ");
                Colors.Add(Console.ReadLine());
            }

            while (true)
            {
                Console.Write("Year of issue: ");
                if (!int.TryParse(Console.ReadLine(), out Year) || Year < 1885) ErrorInfo();
                else break;
            }

            while (true)
            {
                Console.Write("Price: ");
                if (!int.TryParse(Console.ReadLine(), out Price) || Price < 1) ErrorInfo();
                else break;
            }

            Console.Write("Model: ");
            Model = Console.ReadLine();
        }

        public void InputInfoFind()
        {
            Console.WriteLine("Enter the car information. If you don't have it, press 'Enter' to skip: ");
            Console.Write("Enter the color of the car: ");
            Colors.Add(Console.ReadLine());

            while (true)
            {
                Console.Write("Year of issue: ");
                string temp = Console.ReadLine();
                if (temp != string.Empty)
                {
                    if (!int.TryParse(temp, out Year) || Year < 1885) ErrorInfo();
                    else break;
                }
                else
                {
                    Year = 0;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Price: ");
                string temp = Console.ReadLine();
                if (temp != string.Empty)
                {
                    if (!int.TryParse(temp, out Price) || Price < 1) ErrorInfo();
                    else break;
                }
                else
                {
                    Price = 0;
                    break;
                }
            }

            Console.Write("Model: ");
            Model = Console.ReadLine();
        }
        public override string ToString()
        {
            string carInfo = $"\nInformation about the cars: \nColors: ";
            foreach (var color in Colors)
            {
                carInfo += color + " ";
            }
            carInfo += $"\nYear of issue: {Year}\nPrice: {Price}\nModel: {Model}\n";

            return carInfo;
        }
    }
}
