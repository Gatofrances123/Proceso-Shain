namespace CRUD.CRM.Core.Aggregates.Commercial.BookmarkAggregate
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<BookmarkTag> BookmarkTags { get; set; } = null!;
    }
}
