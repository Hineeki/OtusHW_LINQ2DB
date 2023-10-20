using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace HW_LINQ2DB_Library
{
    [Table(Name ="Products")]
    public class Product
    {
        [PrimaryKey]
        [Column(Name="Id")]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Description")]
        public string Description { get; set; }

        [Column(Name = "StockQuantity")]
        public int StockQuantity { get; set; }

        [Column(Name = "Price")]
        public double Price { get; set; }
    }
}
