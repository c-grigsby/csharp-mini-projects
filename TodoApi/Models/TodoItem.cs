﻿namespace TodoApi.Models
{
  public class TodoItem
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string Secret { get; set; }
    public string PersonAssigned { get; set; }
    public int Priority { get; set; }
  }
}
