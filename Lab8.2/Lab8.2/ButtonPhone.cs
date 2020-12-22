using System;
using System.Collections.Generic;


namespace PhoneEvolution
{
    class ButtonPhone : DiskPhone
    {
        public override List<char> AvailableSymbols => new List<char>()
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#'
        };

        public ButtonPhone(string PhoneNum) : base(PhoneNum) { }

        public override void TakeCall(string callingNowNumber)
        {
            Console.WriteLine($"Incoming call from the number {callingNowNumber}");
        }
    }
}