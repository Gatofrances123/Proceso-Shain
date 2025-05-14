namespace CRUD.CRM.data.Config.Commercial.BookmarkAggregate
{
    public class BookmarkTagConfiguration
    {
        public BookmarkTagConfiguration: IEntityTypeConfiguration<BookmarkTag>
        {
            public void Configure(EntityTypeBuilder<BookmarkTag> builder)
        {
            builder.ToTable("BookmarkTag");

            builder.HasKey(b => b.Id);
            builder.HasOne(b => b.Bookmark)
                .WithMany(bt => bt.BookmarkTags)
                .HasForeignKey(bt => bt.BookmarkId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.Tag)
                .WithMany(bt => bt.BookmarkTags)
                .HasForeignKey(bt => bt.TagId)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}
