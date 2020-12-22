using System;
using System.Collections.Generic;


namespace PhoneEvolution
{
    class DiskPhone
    {
        public string PhoneNumber { set; get; }
        public virtual List<char> AvailableSymbols => new List<char>()
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        public DiskPhone(string PhoneNum) { PhoneNumber = PhoneNum; }

        protected string EnterNumber()
        {
            Console.WriteLine("Enter the subscriber's phone number:");
            do
            {
                bool invalid = false;
                string number = Console.ReadLine();

                foreach (char symbol in number)
                {
                    if (!AvailableSymbols.Contains(symbol))
                    {
                        invalid = true;
                        break;
                    }
                }

                if (invalid)
                {
                    Console.WriteLine("Incorrect value, try again: ");
                    continue;
                }

                return number;

            } while (true);
        }
        public virtual void TakeCall(string callingNowNumber)
        {
            Console.WriteLine($"Incoming call {callingNowNumber}");
        }
        public virtual void Call()
        {
            Console.WriteLine($"Call to number {EnterNumber()}");
        }
    }
}