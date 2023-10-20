using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LINQ2DB_Library
{
    public class ClassDataConnection : LinqToDB.Data.DataConnection
    {
        public ClassDataConnection() : base("Config.SqlConnectionString") { }

        public ITable<Product> Product => this.GetTable<Product>();
        public ITable<Customer> Category => this.GetTable<Customer>();
    }
}
