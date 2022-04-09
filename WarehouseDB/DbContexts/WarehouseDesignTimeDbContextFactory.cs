using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDB.DbContexts
{
    public class WarehouseDesignTimeDbContextFactory : IDesignTimeDbContextFactory<WarehouseDbContext>
    {
        public WarehouseDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=WarehouseSystem.db").Options;

            return new WarehouseDbContext(options);
        }
    }
}
