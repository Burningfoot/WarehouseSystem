using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDB.DbContexts;
using WarehouseDB.DTOs;
using WarehouseSystem.Models;

namespace WarehouseSystem.Services.WarehouseCreators
{
    public class DatabaseWarehouseCreator : IWarehouseCreator
    {
        private readonly WarehouseDbContextFactory _dbContextFactory;

        public DatabaseWarehouseCreator(WarehouseDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateWarehouse(Warehouse warehouse)
        {
            using (WarehouseDbContext context = _dbContextFactory.CreateDbContext())
            {
                WarehouseDTO warehouseDTO = ToWarehouseDTO(warehouse);

                context.Warehouses.Add(warehouseDTO);
                await context.SaveChangesAsync();
            }
        }

        private WarehouseDTO ToWarehouseDTO(Warehouse warehouse)
        {
            return new WarehouseDTO()
            {
                Name = warehouse.Name,
                City = warehouse.AddressCityName,
                Street = warehouse.AddressStreet
            };
        }
    }
}
