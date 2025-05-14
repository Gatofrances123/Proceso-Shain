using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Schein.Univer.CRM.Core.Aggregates.Commercial.SalesAggregate;
using CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates;

namespace Schein.Univer.CRM.Data.Config.Commercial.SalesAggregate;

public class BookmarkConfiguration : IEntityTypeConfiguration<ItemSale>
{
    /// <summary>
    /// definicion de clase
    /// </summary>

    public void Configure(EntityTypeBuilder<ItemSale> builder)
    {
        /// <summary>
        /// configuracion de la tabla y clave primaria 
        /// </summary>

        builder.ToTable("ItemSales");

        builder.HasKey(x => x.Id);

        /// <summary>
        /// Referencia de la clase , Relacion & Producto pueda cceder a producto vendido 
        /// </summary>
        builder.HasOne(p => p.Item)
            .WithMany(t => t.ItemSale)
            .HasForeignKey(p => p.ItemId)
            .IsRequired();

        builder.HasOne(pv => pv.Sales)
            .WithMany(p => p.ItemSale)
            .HasForeignKey(pv => pv.SalesId)
            .IsRequired();
    }
}