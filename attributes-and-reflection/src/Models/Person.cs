using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System;

namespace AttributePractice
{
  [Author("Chris Grigsby", "0.0.1")]
  public class Person
  {
    [Required]
    public string FirstName { get; set; }
    [PersonalInformation(1)]
    public string LastName { get; set; }
    [NoJson]
    [PersonalInformation(3)]
    public int SSN { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    [PriorityData(1)]
    public Person()
    {
      FirstName = null;
      LastName = null;
      SSN = 0;
      Age = 0;
      Gender = null;
    }

    [PriorityData(1)]
    public Person(string fname, string lname, int ssn, int age, string gender)
    {
      this.FirstName = fname;
      this.LastName = lname;
      this.SSN = ssn;
      this.Age = age;
      this.Gender = gender;
    }

    [Author("Jojo Rabbit", "0.0.1")]
    public override string ToString()
    {
      return $"Name: {LastName}, {FirstName}\nSSN: {SSN}\nAge: {Age} Gender: {Gender}\n";
    }

    [Author("Jojo Rabbit", "0.0.1")]
    public string ToStringRedacted()
    {
      StringBuilder sb = new StringBuilder();
      Person printPerson = new Person(this.FirstName, this.LastName, this.SSN, this.Age, this.Gender);

      Type t = printPerson.GetType();
      PropertyInfo[] properties = t.GetProperties();
      foreach (PropertyInfo property in properties)
      {
        sb.Append($"{property.Name}: ");
        object[] attributes = property.GetCustomAttributes(true);
        bool flaggedValue = false;
        foreach (object obj in attributes)
        {
          if (obj is PersonalInformationAttribute)
          {
            PersonalInformationAttribute personal_attr = (PersonalInformationAttribute)obj;
            if (personal_attr.Level == 3) flaggedValue = true;
          }
        }
        if (flaggedValue) sb.Append("*****\n");
        else sb.Append($"{property.GetValue(printPerson)}\n");
      }
      return sb.ToString();
    }
  }
}