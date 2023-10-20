using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace HW_LINQ2DB_Library
{
    [Table(Name ="Orders")]
    public class Order
    {
        [PrimaryKey]
        [Column(Name ="Id")]
        public int Id { get; set; }

        [Column(Name = "CustomersId")]
        public int CustomerId { get; set; }

        [Column(Name = "ProductsId")]
        public int ProductId { get; set; }

        [Column(Name = "Quantity")]
        public int Quantity { get; set; }
    }
}
