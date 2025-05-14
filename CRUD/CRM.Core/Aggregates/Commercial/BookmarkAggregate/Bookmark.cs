namespace CRUD.CRM.Core.Aggregates.Commercial.BookmarkAggregate
{
    public class Bookmark
    {
        public int Id { get; set; }
        public string SiteURI { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; } = null!;
    }
}
