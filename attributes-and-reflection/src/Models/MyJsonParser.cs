using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;

namespace AttributePractice
{
  public class MyJsonParser
  {
    public static string parse(object userObject)
    {
      List<string> props_values = new List<string>();

      Type t = userObject.GetType();
      PropertyInfo[] properties = t.GetProperties();
      foreach (PropertyInfo property in properties)
      {
        props_values.Add($"  \"{property.Name}\": \"{property.GetValue(userObject)}\",\n");
        object[] attributes = property.GetCustomAttributes(true);
        foreach (object obj in attributes)
        {
          if (obj is NoJsonAttribute)
          {
            props_values.RemoveAt(props_values.Count - 1);
          }
        }
      }
      StringBuilder sb = new StringBuilder();
      sb.Append("{\n");
      foreach (string str in props_values)
      {
        sb.Append(str);
      }
      sb.Append("}");
      return sb.ToString();
    }
  }
}