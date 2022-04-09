using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDB.DTOs;

namespace WarehouseDB.DbContexts
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<WarehouseDTO> Warehouses { get; set; }
    }
}
