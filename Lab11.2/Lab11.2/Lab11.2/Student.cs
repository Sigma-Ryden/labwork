namespace Lab11._2
{
    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        
        public delegate bool StudentPredicateDelegate(Student student);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static bool IsAdult(Student student) => student.Age >= 18;
        public static bool FirstNameStartsWithA(Student student) => student.FirstName?[0] == 'A';
        public static bool LastNameLongerThanThree(Student student) => student.LastName?.Length > 3;

        public override string ToString()
        {
            return $" | First name: {FirstName} | " +
                   $" | Last Name: {LastName} | " +
                   $" | Age: {Age} | ";
        }
    }
}