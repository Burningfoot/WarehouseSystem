using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.Models;

namespace WarehouseDB.Services
{
    public interface IWarehouseProvider
    {
        Task<IEnumerable<Warehouse>> GetAllWarehouses();
    }
}
