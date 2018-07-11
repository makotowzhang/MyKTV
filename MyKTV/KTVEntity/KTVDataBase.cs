using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV.KTVEntity
{
    public class KTVDataBase : DbContext
    {
        public DbSet<SearchCache> SearchCache { get; set; }

        public DbSet<MyMTV> MyMTV { get; set; }
    }
}
