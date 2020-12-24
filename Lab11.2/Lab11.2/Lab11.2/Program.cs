using System;
using System.Collections.Generic;

namespace Lab11._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Student> students = new List<Student>();
            
            students.Add(new Student("Josh", "Kushnarev", rnd.Next(10, 35)));
            students.Add(new Student("Andrew", "Morris", rnd.Next(10, 35)));
            students.Add(new Student("Adam", "Vitas", rnd.Next(10, 35)));
            students.Add(new Student("Fila", "Hades", rnd.Next(10, 35)));
            students.Add(new Student("Chelsey", "Enstein", rnd.Next(10, 35)));
            students.Add(new Student("July", "Robson", rnd.Next(10, 35)));
            students.Add(new Student("Alex", "Makedonsky", rnd.Next(10, 35)));
            students.Add(new Student("Kate", "Lays", rnd.Next(10, 35)));
            students.Add(new Student("Zabit", "Magomedsharipov", rnd.Next(10, 35)));
            students.Add(new Student("Eve", "Kawabata", rnd.Next(10, 35)));
            students.Add(new Student("Bill", "Gates", rnd.Next(10, 35)));
            students.Add(new Student("Steve", "Troelsen", rnd.Next(10, 35)));

            Console.WriteLine("Age > 18");
            students.FindStudents(Student.IsAdult).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("First letter of First name \"А\"");
            students.FindStudents(Student.FirstNameStartsWithA).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Last Name is Longer then 3");
            students.FindStudents(Student.LastNameLongerThanThree).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Age > 18");
            students.FindStudents(s => s.Age >= 18).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("First letter of First name \"А\"");
            students.FindStudents(s => s.FirstName?[0] == 'A').ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Last Name is Longer then 3");
            students.FindStudents(s => s.LastName?.Length > 3).ForEach(Console.WriteLine);
            Console.WriteLine();
            //Anonymous methods
            Console.WriteLine("Age betwewn 20 and 25");
            students.FindStudents(s => s.Age >= 20 && s.Age <= 25).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Name \"Andrew\"");
            students.FindStudents(s => s.FirstName.Equals("Andrew")).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Surname \"Troelsen\"");
            students.FindStudents(s => s.LastName.Equals("Troelsen")).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}