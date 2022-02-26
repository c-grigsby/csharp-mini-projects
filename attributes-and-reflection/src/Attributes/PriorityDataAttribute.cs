using System;

namespace AttributePractice
{
  public class PriorityDataAttribute : Attribute
  {
    public int Level {get; set;}

    public string Description {get; set;}

    public PriorityDataAttribute(int level)
    {
      this.Level = level;
      if (Level == 1) {
        Description = "Level 1: Data is of high priority";
      }
      else if (Level == 2) {
        Description = "Level 2: Data is of medium priority";
      }
      else if (Level == 3) {
        Description = "Level 3: Data is of low priority";
      } else {
        Description = "Priority level must be <= 3";
      }
    }
  }
}