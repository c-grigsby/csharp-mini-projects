namespace TodoApi.Models
{
  public class TodoItemDTO
  {
    private string status_;
    public long Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string PersonAssigned { get; set; }
    public int Priority { get; set; }
  }
}
