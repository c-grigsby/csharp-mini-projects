using System;
using System.Collections.Generic;

namespace AttributePractice
{
  class Program
  {
    static void Main(string[] args)
    {
      Person p1 = new Person()
      {
        FirstName = "Bob",
        LastName = "Smith",
        SSN = 333333333,
        Age = 22,
        Gender = "Male"
      };
      Person p2 = new Person()
      {
        FirstName = "Jane",
        LastName = "Smithson",
        SSN = 444444444,
        Age = 17,
        Gender = "Female"
      };
      Person p3 = new Person()
      {
        FirstName = "Carol",
        LastName = "Tombs",
        SSN = 555555555,
        Age = 49,
        Gender = "Female"
      };
      Person p4 = new Person()
      {
        FirstName = "Josh",
        LastName = "Welks",
        SSN = 666666666,
        Age = 34,
        Gender = "Male"
      };
      Person p5 = new Person()
      {
        FirstName = "Jane",
        LastName = "Jacobs",
        SSN = 777777777,
        Age = 29,
        Gender = "Male"
      };
      List<Person> people = new List<Person> { p1, p2, p3, p4, p5 };

      Address s1 = new Address("421 Sweeny Todd Rd.", "11A", "East Templeton", "NY", 58597);

      Console.WriteLine(s1.ToString());
      Console.WriteLine(p1.ToStringRedacted());

      System.Console.WriteLine(MyJsonParser.parse(s1) + "\n");
      System.Console.WriteLine(MyJsonParser.parse(p1));
    }
  }
}
