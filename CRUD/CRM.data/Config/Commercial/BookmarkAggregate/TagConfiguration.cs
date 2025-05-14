namespace CRUD.CRM.data.Config.Commercial.BookmarkAggregate
{
    public class Tag
    {

        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");
            builder.HasKey(b => b.Id);

            builder.HasMany(b => b.BookmarkTags)
                .WhitOne(bt => bt.Tag)
                .HasForeignKey(bt => bt.TagId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(w => w._Creator)
                .WhitMany()
                .HasForeignKey(w => w._CreatorAuth0Id)
                .OnDelete(DeleteBehavior.Restict);

            builder.HasOne(w => w._Updater)
                .WhitMany()
                .HasForeignKey(w => w._UpdaterAuth0Id)
                .OnDelete(DeleteBehavior.Restict);

            builder.Property(p => p._UpdaterAuth0Id)
                .IsRequired(false);
        }
    }
}
