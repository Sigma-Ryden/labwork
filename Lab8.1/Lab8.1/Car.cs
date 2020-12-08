using System;

namespace Lab8._1
{
    class Car
    {
        public string name { get; }
        public string color { get; }
        public int speed { get; }
        public int year { get; }
        public Car(string name, string color, int speed, int year)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            this.year = year;
        }
        public void GetCar()
        {
            Console.WriteLine($"You take a car: {color} {name} {year}");
        }
        public override string ToString()
        {
            return $"\tName: {name}\n\tColor: {color}\n\tSpeed: {speed}\n\tYear: {year}\n";
        }
    }
}
