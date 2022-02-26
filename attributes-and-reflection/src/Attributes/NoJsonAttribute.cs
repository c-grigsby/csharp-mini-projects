using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System;

namespace AttributePractice
{
  public class NoJsonAttribute : Attribute
  {
    public string Description { get; set; }

    public NoJsonAttribute()
    {
      Description = "This property should not be converted to JSON";
    }

    
  }
}