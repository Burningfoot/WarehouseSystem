using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDB.Services;
using WarehouseSystem.Services.WarehouseCreators;

namespace WarehouseSystem.Models
{
    public class Warehouse
    {
        private readonly IWarehouseProvider _warehouseProvider;
        private readonly IWarehouseCreator _warehouseCreator;

        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCityName { get; set; }
        public int Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public Supervisor Supervisor { get; set; }

        public Warehouse(string name, string street, string city)
        {
            Name = name;
            AddressStreet = street;
            AddressCityName = city;
        }
        public Warehouse()
        {

        }

        public async Task<IEnumerable<Warehouse>> GetAllWarehouses()
        {
            return await _warehouseProvider.GetAllWarehouses();
        }

        public async Task AddWarehouse(Warehouse warehouse)
        {
            await _warehouseCreator.CreateWarehouse(warehouse);
        }
    }
}
