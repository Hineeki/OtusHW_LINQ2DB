using LinqToDB.Mapping;

namespace HW_LINQ2DB_Library
{
    [Table(Name = "Customers")]
    public class Customer
    {
        [PrimaryKey]
        [Column(Name = "Id")]
        public int Id { get; set; }

        [Column(Name = "FirstName")]
        public string FirstName { get; set; }

        [Column(Name = "LastName")]
        public string LastName { get; set; }

        [Column(Name = "Age")]
        public int Age { get; set; }
    }
}