namespace CRUD.CRM.Core.Aggregates.Commercial.BookmarkAggregate
{
    public class BookmarkTag
    {
        public int Id { get; set; }
        public int BookmarkId { get; set; }
        public virtual Bookmark Bookmark { get; set; } = null!;
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; } = null!; 
    }
}
