using System;

namespace AttributePractice
{
  public class PersonalInformationAttribute : Attribute
  {
    public int Level { get; set; }
    public PersonalInformationAttribute(int level)
    {
      Level = level;
    }
  }
}