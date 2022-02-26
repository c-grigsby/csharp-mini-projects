// System.Console.WriteLine("==== ToString ====");
// foreach (Person p in people)
// {
//   System.Console.WriteLine(p.ToString());
// }

// System.Console.WriteLine("==== ToStringRedacted ====");
// foreach (Person p in people)
// {
//   Console.WriteLine(p.ToStringRedacted());
// }

// System.Console.WriteLine("=== Attribute Data ===");
// Type t1 = p1.GetType();
// // Member data for the object
// MemberInfo[] m = t1.GetMembers();
// foreach (MemberInfo mi in m)
// {
//   System.Console.WriteLine(mi);
//   Console.WriteLine(mi);
//   object[] attributes = mi.GetCustomAttributes(true);
//   foreach (object o in attributes)
//   {
//     Console.WriteLine(o);
//     if (o is PersonalInformationAttribute)
//     {
//       System.Console.WriteLine("=== Personal Information Attribute ===");
//       System.Console.WriteLine("Do not print...");

//       PersonalInformationAttribute pia = (PersonalInformationAttribute)o;
//       if (pia.Level == 3)
//       {
//         System.Console.WriteLine("Personal Information Level 3: Super private");
//       }
//       else
//       {
//         System.Console.WriteLine("Personal Information Level < 3: Sort of private");
//       }
//     }

//     if (o is AuthorAttribute)
//     {
//       System.Console.WriteLine("=== Author Attribute ===");

//       AuthorAttribute authorAttr = (AuthorAttribute)o;
//       Console.WriteLine(authorAttr.Author);
//       Console.WriteLine(authorAttr.Version);
//     }

//     if (o is PriorityDataAttribute)
//     {
//       System.Console.WriteLine("=== Priority Data ===");

//       PriorityDataAttribute priorityDataAttr = (PriorityDataAttribute)o;
//       Console.WriteLine(priorityDataAttr.Level);
//       Console.WriteLine(priorityDataAttr.Description);
//     }
//   }
//   System.Console.WriteLine("======================");
// }