using System;
using System.Linq;

namespace Lab8._1
{
    class Program
    {
        static void showEntryMessage()
        {
            Console.Write(
                    "Current options:\n" +
                    "1. Add car\n" +
                    "2. Remove car\n" +
                    "3. Take a car for ride\n" +
                    "4. Check garage\n" +
                    "5. Exit\n" +
                    "Please choose option: ");
        }
        static void showError()
        {
            Console.Write("Incorrect value, try again: ");
        }
        static Car EnterDataOfCar()
        {
            string name;
            string color;
            int speed;
            int year;

            Console.WriteLine("Please enter info about the car");

            Console.Write("Enter the name of car: ");

            do
            {
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name)) showError();
            }
            while (string.IsNullOrEmpty(name));

            Console.Write("Enter the color of car: ");
            do
            {
                color = Console.ReadLine();
                if (string.IsNullOrEmpty(color)) showError();
            }
            while (string.IsNullOrEmpty(color));

            Console.Write("Enter the speed of car: ");
            while (!int.TryParse(Console.ReadLine(), out speed) || speed < 0) showError();

            Console.Write("Enter the year of car: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year < 0) showError();

            return new Car(name, color, speed, year);
        }

        static int Main(string[] args)
        {
            CarSpace garage = new CarSpace();

            while (true)
            {
                showEntryMessage();

                int option;

                while (!int.TryParse(Console.ReadLine(), out option)|| option <= 0 || option > 5) showError();

                switch (option)
                {
                case 1:
                    Car redictingCar = EnterDataOfCar();
                    garage.AddCar(redictingCar);
                    Console.WriteLine("Success!\n ");
                    break;

                case 4:
                    Console.WriteLine(garage);
                    break;

                case 5:
                    break;

                default:
                    var choise = garage.GetCars(EnterDataOfCar());
                    if (choise.Count() <= 0)
                    {
                        Console.WriteLine("Car not found!");
                        continue;
                    }

                    Console.WriteLine("List of cars");
                    for (int i = 0; i < choise.Count(); i++)
                        Console.WriteLine($"Number of car {i + 1}:\n{choise.ElementAt(i)}");

                    if (option == 2)
                    {
                        if (choise.Count() > 1)
                        {
                            int chsNum;

                            Console.Write("Choose car by number: ");

                            while (!int.TryParse(Console.ReadLine(), out chsNum) || chsNum <= 0 || chsNum > choise.Count())
                            {
                                showError();
                            }
                            garage.RemoveCar(choise.ElementAt(chsNum - 1));
                        }
                        else garage.RemoveCar(choise.ElementAt(0));
                        Console.WriteLine("Car has been removed!");
                    }

                    else if (option == 3)
                    {
                        if (choise.Count() > 1)
                        {
                            Console.Write("Choose car by number: ");
                            int chsNum;
                            while (!int.TryParse(Console.ReadLine(), out chsNum) || chsNum <= 0 || chsNum > choise.Count())
                            {
                                showError();
                            }
                            choise.ElementAt(chsNum - 1).GetCar();
                        }
                        else choise.ElementAt(0).GetCar();
                    }

                    break;
                }
                Console.WriteLine();
            }
        }
    }
}