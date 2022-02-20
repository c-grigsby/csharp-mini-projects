using System;

namespace AttributePractice
{
  public class AuthorAttribute : Attribute
  {
    public string Author { get; set; }
    public string Version { get; set; }

    public AuthorAttribute(string name, string version)
    {
      this.Author = name;
      this.Version = version;
    }
  }
}