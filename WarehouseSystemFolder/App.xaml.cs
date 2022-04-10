using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WarehouseDB.DbContexts;

namespace WarehouseSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=Warehouse.db";

        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            using (WarehouseDbContext dbContext = new WarehouseDbContext(options))
            {
                dbContext.Database.Migrate();
            }

                

            base.OnStartup(e);
        }


    }
}
