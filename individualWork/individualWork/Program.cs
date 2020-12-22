using System;
using System.Text;


namespace individualWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CarCollection carsCollection = new CarCollection();

            Console.WriteLine("Welcome to the =Auto-Car= store! \nPlease enter information about 5 cars");

            for (int i = 0; i < 5; i++)
            {
                Cars cars = new Cars();
                Console.WriteLine($"Enter information about {i + 1} car");
                cars.InputInfo();
                carsCollection.AddCars(cars);
            }

            bool workShop = true;
            while (workShop)
            {
                Console.WriteLine("\n[1] Find the desired car model\n[2] Display all car models\n[0] Exit");
                int select;
                while (true)
                {
                    Console.Write(" Your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out select) || select > 0 || select < 2) break;
                    else Console.WriteLine("Error. Try again: ");
                }

                switch (select)
                {
                    case 0:
                        workShop = false;
                        break;

                    case 1:
                        Cars carsFind = new Cars();
                        carsFind.InputInfoFind();
                        carsCollection.PrintInfoCars(carsCollection.FindCar(carsFind));
                        break;

                    case 2:
                        carsCollection.PrintInfoCars();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
