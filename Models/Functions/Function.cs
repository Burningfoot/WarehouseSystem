using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.Functions
{
    public interface Function
    {
        string Name { get; set; }
        List<Warehouse> DataList { get; set; }
    }
}
