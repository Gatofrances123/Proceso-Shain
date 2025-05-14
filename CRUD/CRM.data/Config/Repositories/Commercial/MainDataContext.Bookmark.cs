using CRUD.CRM.Core.Aggregates.Commercial.SaleAggregates;
using System.Collections.Generic;

namespace CRUD.CRM.data.Config.Repositories.Commercial
{
    public partial class MainDataContext
    {
        public DbSet<Bookmark> Bookmarks { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
