using System;
using System.Collections.Generic;
using RentalLibrary;

namespace TV
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Show one = new Show()
      {
        Name = "Parks and Recreation",
        NumEpisodes = 125,
        Year = 2009,
        Actors = new List<string>{
                   "Amy Poehler", "Aziz Ansari", "Nick Offerman"
                }
      };
      Show two = new Show()
      {
        Name = "Burn Notice",
        NumEpisodes = 111,
        Year = 2007,
        Actors = new List<string>{
                   "Jeffery Donovan", "Gabriel Anwar", "Bruce Cambell"
                }
      };
      Show three = new Show()
      {
        Name = "The X-Files",
        NumEpisodes = 217,
        Year = 1993,
        Actors = new List<string>{
                   "David Duchovny", "Gillian Anderson", "Mitch Pileggi"
                }
      };
      List<Show> shows = new List<Show>(){
                one, two, three
            };

      Console.WriteLine("----- Before Aplha Sort Sort ------");
      printList(shows);

      shows.Sort();

      Console.WriteLine("====== After Aplha Sort (Show: Name) ======");
      printList(shows);

      shows.Sort(new NumEpisodeComparer());

      Console.WriteLine("====== After Num of Episode Sort ======");
      printList(shows);

      Console.WriteLine("\n====== Create a List<T> of 7 Tool objects ======\n");
      Tool t1 = new Tool()
      {
        ItemId = 0001,
        Name = "Ol' Rusty",
        Description = "Chainsaw born in 1957",
        DailyRentalCost = 10.00,
        ReplacementCost = 2000.00,
        QuantityAvailable = 1,
        ReportedInjuries = 784
      };

      Tool t2 = new Tool()
      {
        ItemId = 4576,
        Name = "Metabo HPT NR90AES1 ",
        Description = "Professional Nail Gun",
        DailyRentalCost = 14.99,
        ReplacementCost = 120.00,
        QuantityAvailable = 5,
        ReportedInjuries = 23
      };

      Tool t3 = new Tool()
      {
        ItemId = 2342,
        Name = "John Deere S100",
        Description = "Riding Lawn Mower",
        DailyRentalCost = 75.99,
        ReplacementCost = 2000.00,
        QuantityAvailable = 3,
        ReportedInjuries = 4
      };

      Tool t4 = new Tool()
      {
        ItemId = 5581,
        Name = "CRAFTSMAN M110",
        Description = "Gas Push Mower",
        DailyRentalCost = 20.99,
        ReplacementCost = 284.00,
        QuantityAvailable = 8,
        ReportedInjuries = 6
      };

      Tool t5 = new Tool()
      {
        ItemId = 8865,
        Name = "CRAFTSMAN WS4200 ",
        Description = "Gas Weed Wacker",
        DailyRentalCost = 12.99,
        ReplacementCost = 229.00,
        QuantityAvailable = 9,
        ReportedInjuries = 3
      };

      Tool t6 = new Tool()
      {
        ItemId = 3247,
        Name = "SIMPSON MegaShot 3000",
        Description = "Cold-Water Pressure Washer",
        DailyRentalCost = 39.99,
        ReplacementCost = 379.00,
        QuantityAvailable = 4,
        ReportedInjuries = 7
      };

      Tool t7 = new Tool()
      {
        ItemId = 0923,
        Name = "Leveler M22",
        Description = "22ft Ladder",
        DailyRentalCost = 10.99,
        ReplacementCost = 274.00,
        QuantityAvailable = 5,
        ReportedInjuries = 21
      };
      List<Tool> rentalTools = new List<Tool>{
        t1, t2, t3, t4, t5, t6, t7
      };
      printList(rentalTools);

      System.Console.WriteLine("====== List Sorted by ItemId: Default ======\n");
      rentalTools.Sort();
      printList(rentalTools);

      System.Console.WriteLine("====== List Sorted by Name ======\n");
      rentalTools.Sort(new ToolNameComparer());
      printList(rentalTools);

      System.Console.WriteLine("====== List Sorted by Daily Rental Cost ======\n");
      rentalTools.Sort(new ToolDailyRentalCostComparer());
      printList(rentalTools);

      System.Console.WriteLine("====== List Sorted by Quantity Available ======\n");
      rentalTools.Sort(new ToolQuantityAvailableComparer());
      printList(rentalTools);

      System.Console.WriteLine("====== List Sorted by ReportedInjuries ======\n");
      rentalTools.Sort(new ToolReportedInjuriesComparer());
      printList(rentalTools);

      void printList<T>(List<T> list)
      {
        foreach (T item in list)
        {
          Console.WriteLine(item.ToString());
        }
      }
    }
  }

  public class NumEpisodeComparer : IComparer<Show>
  {
    public int Compare(Show x, Show y)
    {
      return x.NumEpisodes - y.NumEpisodes;
    }
  }
}
