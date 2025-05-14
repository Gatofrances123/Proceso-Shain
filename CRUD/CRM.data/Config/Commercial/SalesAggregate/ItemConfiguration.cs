using CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schein.Univer.CRM.Core.Aggregates.Commercial.SalesAggregate;
namespace Schein.Univer.CRM.Data.Config.Commercial.SalesAggregate;

/// <summary>
/// Se llama la trasabilidad para llamar los correspondientes campos 
/// </summary>
public class TagConfiguration : IEntityTypeConfiguration<Item>
{
    /// <summary>
    /// definicion de clase
    /// </summary>
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        /// <summary>
        /// configuracion de la tabla y clave primaria 
        /// </summary>
        builder.ToTable("Items");
        builder.HasKey(x => x.Id);

        /// <summary>
        /// propiedades con restriccion
        /// </summary>
        builder.Property(x => x.Name)
            .IsRequired().HasMaxLength(150);

        builder.Property(u => u.Price)
            .HasColumnType(
                "decimal(10, 2)")
            .IsRequired();

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