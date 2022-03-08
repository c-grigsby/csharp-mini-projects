using System;

namespace ValueVsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 3;

            int r = SquareX(y);
            Console.WriteLine(r);

            int r2 = CubeX(y);
            Console.WriteLine(r2);
        }

        public static int SquareX(int x)
        {
            int response = x * x;
            return response;
        }

        public static int CubeX(int x)
        {
            int tempRes = SquareX(x);
            int response = tempRes * x;
            return response;
        }

        public static string FormatPerson(Person person)
        {
            string result;
            result = person.LastName + ", " + person.FirstName;
            person.LastName = "Whitaker";
            return result;
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}