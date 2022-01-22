using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RentalLibrary
{
  class Tool : IComparable<Tool>
  {
    private int _memberDiscount;
    public int ItemId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double DailyRentalCost { get; set; }
    public double ReplacementCost { get; set; }
    public int QuantityAvailable { get; set; }
    public int ReportedInjuries { get; set; }

    public int MembershipDiscount
    {
      get { return _memberDiscount; }
      set
      {
        if (value < 0 || value > 1)
        {
          throw new ArgumentOutOfRangeException(
            $"{nameof(value)} must be between 0 and 1."
          );
        }
      }
    }

    public override string ToString()
    {
      return $"Item ID: {this.ItemId}\nName: {Name}\nDesc: {Description}\nDaily Rental Cost: ${DailyRentalCost}\nReplacement Cost: ${ReplacementCost}\nQuantity Available: {QuantityAvailable}\nReported Injuries: {ReportedInjuries}\n----------------\n";
    }

    public int CompareTo(Tool otherTool)
    {
      return this.ItemId.CompareTo(otherTool.ItemId);
    }
  }

  public class ToolNameComparer : IComparer<Tool>
  {
    int IComparer<Tool>.Compare(Tool x, Tool y)
    {
      return ((new CaseInsensitiveComparer()).Compare(x.Name, y.Name));
    }
  }
  public class ToolDailyRentalCostComparer : IComparer<Tool>
  {
    int IComparer<Tool>.Compare(Tool x, Tool y)
    {
      return x.DailyRentalCost.CompareTo(y.DailyRentalCost);
    }
  }
  public class ToolQuantityAvailableComparer : IComparer<Tool>
  {
    int IComparer<Tool>.Compare(Tool x, Tool y)
    {
      return x.QuantityAvailable.CompareTo(y.QuantityAvailable);
    }
  }
  public class ToolReportedInjuriesComparer : IComparer<Tool>
  {
    int IComparer<Tool>.Compare(Tool x, Tool y)
    {
      return x.ReportedInjuries.CompareTo(y.ReportedInjuries);
    }
  }
}