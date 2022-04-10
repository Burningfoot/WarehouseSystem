using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDB.DbContexts
{
    public class WarehouseDbContextFactory
    {
        private readonly string _connectionString;

        public WarehouseDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public WarehouseDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new WarehouseDbContext(options);
        }
    }
}
