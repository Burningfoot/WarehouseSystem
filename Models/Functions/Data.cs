using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseSystem.Models.Functions
{
    public class Data:IFunction
    {
        public string  Name { get; set; }
        public List<Warehouse> DataList { get; set; }
        public Data()
        {
            Name = "Data";
            DataList = GetWarehouses();
        }

        static List<Warehouse> GetWarehouses()
        {
            var list = new List<Warehouse>();
            list.Add(new Warehouse() { AddressCityName = "City1", AddressStreet = "Steetname1", Name = "Warehouse1", PhoneNumber = "123123123123", Postcode = 12345, Supervisor = new Supervisor() { Name = "Super1" } });
            list.Add(new Warehouse() { AddressCityName = "City2", AddressStreet = "Steetname2", Name = "Warehouse2", PhoneNumber = "123123123123", Postcode = 12345, Supervisor = new Supervisor() { Name = "Super2" } });
            list.Add(new Warehouse() { AddressCityName = "City3", AddressStreet = "Steetname3", Name = "Warehouse3", PhoneNumber = "123123123123", Postcode = 12345, Supervisor = new Supervisor() { Name = "Super3" } });
            list.Add(new Warehouse() { AddressCityName = "City4", AddressStreet = "Steetname4", Name = "Warehouse4", PhoneNumber = "123123123123", Postcode = 12345, Supervisor = new Supervisor() { Name = "Super4" } });
            list.Add(new Warehouse() { AddressCityName = "City5", AddressStreet = "Steetname5", Name = "Warehouse5", PhoneNumber = "123123123123", Postcode = 12345, Supervisor = new Supervisor() { Name = "Super5" } });
            list.Add(new Warehouse() { AddressCityName = "City6", AddressStreet = "Steetname6", Name = "Warehouse6", PhoneNumber = "123123123123", Postcode = 12345, Supervisor = new Supervisor() { Name = "Super6" } });
            return list;
        }
    }
}
