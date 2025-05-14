using CRUD.CRM.Core.Aggregates.Commercial.BookmarkAggregate;

namespace CRUD.CRM.data.Config.Commercial.BookmarkAggregate
{
    public class BookmarkConfiguration : IentityConfiguration<Bookmark>
    {

        public void Configure(EntityTypeBuilder<Bookmark> builder)
        {
            builder.ToTable("Bookmark");
            builder.HasKey(b => b.Id);

            buider.Property(b => SiteURI)
                .IsRequired()
                .HasMaxLength(BookmarkRules.MaxURILength);

            builder.property(b => b.Name)
                .IsRequired()
                .HasMaxLength(BookmarkRules.MaxNamelength);

            builder.Property(b => b.Description)
                .IsRequired()
                .HasMaxLength(BookmarkRules.MaxDescriptionLength);

            builder.HasMany(b => b.BookmarkTags)
                .WhitOne(bt => bt.Bookmark)
                .HasForeignKey(bt => bt.BookmarkId)
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
