using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDB.DbContexts;
using WarehouseDB.DTOs;
using WarehouseDB.Services;
using WarehouseSystem.Models;

namespace WarehouseSystem.Services
{
    public class DatabaseWarehouseProvider : IWarehouseProvider
    {
        private readonly WarehouseDbContextFactory _dbContextFactory;

        public DatabaseWarehouseProvider(WarehouseDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Warehouse>> GetAllWarehouses()
        {

            using (WarehouseDbContext context = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<WarehouseDTO> warehouseDTOs =  await context.Warehouses.ToListAsync();

                return warehouseDTOs.Select(w => ToWarehouse(w));
            }
        }
        private static Warehouse ToWarehouse(WarehouseDTO dto)
        {
            return new Warehouse(dto.Name, dto.Street, dto.City);
        }
    }
}
