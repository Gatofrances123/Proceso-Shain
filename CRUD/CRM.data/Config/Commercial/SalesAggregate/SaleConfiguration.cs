using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Schein.Univer.CRM.Core.Aggregates.Commercial.SalesAggregate;
using Schein.Univer.CRM.CrossLayers.API.Commercial.Sales;
using CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates;

namespace Schein.Univer.CRM.Data.Config.Commercial.SalesAggregate;

public class BookmarkTagConfiguration : IEntityTypeConfiguration<Sale>
{
    /// <summary>
    /// definicion de clase
    /// </summary>

    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        /// <summary>
        /// configuracion de la tabla y clave primaria 
        /// </summary>
        builder.ToTable("Sales");
        builder.HasKey(x => x.Id);


        /// <summary>
        /// propiedades con restriccion
        /// </summary>
        builder.Property(x => x.Document)
            .IsRequired().HasMaxLength(TagsRules.MaxDocumentLength);

        builder.Property(x => x.Email)
            .IsRequired().HasMaxLength(TagsRules.MaxEmailLength);

        /// <summary>
        /// Relaciones con otras tablas
        /// </summary>
        builder.HasOne(w => w._Creator)
            .WithMany()
            .HasForeignKey(w => w._CreatorAuth0Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(w => w._Updater)
            .WithMany()
            .HasForeignKey(w => w._UpdaterAuth0Id)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(p => p._UpdaterAuth0Id)
            .IsRequired(false);
    }
}