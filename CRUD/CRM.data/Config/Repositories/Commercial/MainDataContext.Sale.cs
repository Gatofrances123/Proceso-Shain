using CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates;
using System.Collections.Generic;

namespace CRUD.CRM.data.Config.Repositories.Commercial
{
    public class MainDataContext
    {
        /// <summary>
        /// Relacion de Producto con el DbSet
        /// </summary>
        public DbSet<Item> Items { get; set; }
        /// <summary>
        /// Relacion de ProductoVendido con el DbSet
        /// </summary>
        public DbSet<ItemSale> ItemSales { get; set; }
        /// <summary>
        /// Relacion de ventas con el DbSet
        /// </summary>
        public DbSet<Sale> Sales { get; set; }
    }
}
