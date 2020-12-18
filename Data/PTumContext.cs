using Microsoft.EntityFrameworkCore;
using PTum.Models;

namespace PTum.Data
{
    public class PTumContext : DbContext
    {
        public PTumContext (DbContextOptions<PTumContext> options)
            : base(options)
        {
        }
        public DbSet<PTum.Models.Tb_mst_product> Tb_mst_product { get; set; }
        public DbSet<PTum.Models.Tb_stock_in> Tb_stock_in { get; set; }
        public DbSet<PTum.Models.Balance_V> Balance_V { get; set; }
        public DbSet<PTum.Models.Tb_stock_out> Tb_stock_out { get; set; }


    }
}