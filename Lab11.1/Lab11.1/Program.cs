using System;

namespace Lab11._1
{
    class Program
    {
        static ServiceCenter.ServiceCenterDelegate RequestForCostumer(ServiceCenter service)
        {
            ServiceCenter.ServiceCenterDelegate operation = null;
            ConsoleKey replay;

            while (true)
            {
                Console.Write("ReinstallWindows? [y/n]");
                replay = Console.ReadKey(false).Key;

                if (replay == ConsoleKey.Y) operation += service.ReinstallWindows;
                else if (replay != ConsoleKey.N) continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("ReplaceMotherboard? [y/n]");
                replay = Console.ReadKey(false).Key;

                if (replay == ConsoleKey.Y) operation += service.ReplaceMotherboard;
                else if (replay != ConsoleKey.N) continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("ReplacePowerSupply? [y/n]");
                replay = Console.ReadKey(false).Key;

                if (replay == ConsoleKey.Y) operation += service.ReplacePowerSupply;
                else if (replay != ConsoleKey.N) continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("AddRAM? [y/n]");
                replay = Console.ReadKey(false).Key;

                if (replay == ConsoleKey.Y) operation += service.AddRAM;
                else if (replay != ConsoleKey.N) continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("ReplaceVideoCard? [y/n]");
                replay = Console.ReadKey(false).Key;

                if (replay == ConsoleKey.Y) operation += service.ReplaceVideoCard;
                else if (replay != ConsoleKey.N) continue;

                Console.WriteLine();
                break;
            }
            while (true)
            {
                Console.Write("ToConfigurePrograms? [y/n]");
                replay = Console.ReadKey(false).Key;

                if (replay == ConsoleKey.Y) operation += service.ToConfigurePrograms;
                else if (replay != ConsoleKey.N) continue;

                Console.WriteLine();
                break;
            }

            return operation;
        }

        static ServiceCenter.ServiceCenterDelegate AllOption(ServiceCenter service)
        {
            ServiceCenter.ServiceCenterDelegate operation = null;

            operation += service.ReinstallWindows;
            operation += service.ReplaceMotherboard;
            operation += service.ReplacePowerSupply;
            operation += service.AddRAM;
            operation += service.ReplaceVideoCard;
            operation += service.ToConfigurePrograms;

            return operation;
        }

        static ServiceCenter.ServiceCenterDelegate FirstPartOption(ServiceCenter service)
        {
            ServiceCenter.ServiceCenterDelegate operation = null;

            operation += service.ReplaceMotherboard;
            operation += service.ReplacePowerSupply;
            operation += service.AddRAM;
            operation += service.ReplaceVideoCard;

            return operation;
        }

        static ServiceCenter.ServiceCenterDelegate SecondPartOption(ServiceCenter service)
        {
            ServiceCenter.ServiceCenterDelegate operation = null;

            operation += service.ReinstallWindows;
            operation += service.ToConfigurePrograms;

            return operation;
        }

        static void Main()
        {
            ServiceCenter service = new ServiceCenter();
            Console.WriteLine("All Information");

            Console.WriteLine("\nFirst computer (all option): ");
            Computer acer = new Computer();
            Console.WriteLine(acer);
            Console.WriteLine();
            AllOption(service).Invoke(acer);

            Console.WriteLine();

            Console.WriteLine("\nSecond computer (first part option): ");
            Computer lenovo = new Computer();
            Console.WriteLine(lenovo);
            Console.WriteLine();
            FirstPartOption(service).Invoke(lenovo);

            Console.WriteLine();

            Console.WriteLine("\nLast computer (second part option): ");
            Computer asus = new Computer();
            Console.WriteLine(asus);
            Console.WriteLine();
            SecondPartOption(service).Invoke(asus);

            ServiceCenter.ServiceCenterDelegate operation = RequestForCostumer(service);

            if (operation == null)
            {
                Console.WriteLine("Operation not selected!");
            }
            else
            {
                operation.Invoke(asus);
                Console.WriteLine(asus);
            }
            Console.ReadKey();
        }


    }
}