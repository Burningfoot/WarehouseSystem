using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.Models;

namespace WarehouseSystem.Services.WarehouseCreators
{
    public interface IWarehouseCreator
    {
        Task CreateWarehouse(Warehouse warehouse);
    }
}
