using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.Functions
{
    public class NewCustomer : IFunction
    {
        public string Name { get; set; }
        public List<Warehouse> DataList { get; set; }

        public NewCustomer()
        {
            Name = "New Customer";
            DataList = new List<Warehouse>();
        }
    }
}
