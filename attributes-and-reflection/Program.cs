using System;
using System.Collections.Generic;
using System.Reflection;

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
      
      System.Console.WriteLine("==== ToString ====");
      foreach (Person p in people)
      {
        System.Console.WriteLine(p.ToString());
      }

      System.Console.WriteLine("==== ToStringRedacted ====");
      foreach (Person p in people)
      {
        Console.WriteLine(p.ToStringRedacted());
      }

      System.Console.WriteLine("=== Attribute Data ===");
      Type t1 = p1.GetType();
      // Member data for the object
      MemberInfo[] m = t1.GetMembers();
      foreach (MemberInfo mi in m)
      {
        System.Console.WriteLine(mi);
        Console.WriteLine(mi);
        object[] attributes = mi.GetCustomAttributes(true);
        foreach (object o in attributes)
        {
          Console.WriteLine(o);
          if (o is PersonalInformationAttribute)
          {
            System.Console.WriteLine("=== Personal Information Attribute ===");
            System.Console.WriteLine("Do not print...");

            PersonalInformationAttribute pia = (PersonalInformationAttribute)o;
            if (pia.Level == 3)
            {
              System.Console.WriteLine("Personal Information Level 3: Super private");
            }
            else
            {
              System.Console.WriteLine("Personal Information Level < 3: Sort of private");
            }
          }

          if (o is AuthorAttribute)
          {
            System.Console.WriteLine("=== Author Attribute ===");

            AuthorAttribute authorAttr = (AuthorAttribute)o;
            Console.WriteLine(authorAttr.Author);
            Console.WriteLine(authorAttr.Version);
          }

          if (o is PriorityDataAttribute)
          {
            System.Console.WriteLine("=== Priority Data ===");

            PriorityDataAttribute priorityDataAttr = (PriorityDataAttribute)o;
            Console.WriteLine(priorityDataAttr.Level);
            Console.WriteLine(priorityDataAttr.Description);
          }
        }
        System.Console.WriteLine("======================");
      }
    }
  }
}
