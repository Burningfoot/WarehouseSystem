using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models
{
    public class Warehouse
    {
        public string Name { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCityName { get; set; }
        public int Postcode { get; set; }
        public string PhoneNumber { get; set; }

    }
}
