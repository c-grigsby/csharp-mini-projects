using System;
using System.Collections.Generic;


WorkingWithStrings();

// List<int>
var fibonacciNumbers = new List<int> { 1, 1 };
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
  Console.WriteLine(item);
}

// method: WorkingWithStrings => a tutorial on List<string> functionality
void WorkingWithStrings()
{
  // List<string>
  var names = new List<string> { "Chris", "Ana", "Felipe" };
  foreach (var name in names)
  {
    Console.WriteLine($"Hello {name.ToUpper()}!");
  }

  // modify
  Console.WriteLine();
  names.Add("Maria");
  names.Add("Bill");
  names.Remove("Ana");
  foreach (var name in names)
  {
    Console.WriteLine($"Hello {name.ToUpper()}!");
  }

  // access
  Console.WriteLine($"My name is {names[0]}");
  Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

  // length
  Console.WriteLine($"The list has {names.Count} people in it");

  // search (IndexOf)
  var index = names.IndexOf("Felipe");

  if (index == -1)
  {
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
  }
  else
  {
    Console.WriteLine($"The name {names[index]} is at index {index}");
  }

  index = names.IndexOf("Not Found");
  if (index == -1)
  {
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
  }
  else
  {
    Console.WriteLine($"The name {names[index]} is at index {index}");

  }

  // sort
  names.Sort();
  foreach (var name in names)
  {
    Console.WriteLine($"Hello {name.ToUpper()}!");
  }
}