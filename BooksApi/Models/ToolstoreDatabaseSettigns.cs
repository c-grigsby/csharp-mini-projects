namespace BooksApi.Models
{
    public class ToolstoreDatabaseSettings : IToolstoreDatabaseSettings
    {
        public string ToolsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IToolstoreDatabaseSettings
    {
        string ToolsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}