using HW_LINQ2DB_Library;
using LinqToDB;
using LinqToDB.Data;

namespace OtusHW_LINQ2DB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
                using (var db = new DataConnection(ProviderName.PostgreSQL, Config.SqlConnectionString))
            {
                var customers = db.GetTable<Customer>()
                    .Where(x=>x.Age > 25)
                    .OrderByDescending(x=>x.Age)
                    .ToList();
                var customers2 = db.Select<Customer>;
                var products = db.GetTable<Product>()
                    .Where(x=>x.StockQuantity > 15)
                    .OrderBy(x=>x.StockQuantity)
                    .ToList();
                var orders = db.GetTable<Order>()
                    .Where(x => x.Quantity > 2)
                    .Count();

                customers.ForEach(PrintCustomer);
                Console.WriteLine();
                products.ForEach(PrintProducts);
                Console.WriteLine();
                Console.WriteLine("Кол-во одинаковых заказов одним человеком: "+orders);
            }
            //    using (var db = new DataConnection(ProviderName.PostgreSQL, Config.SqlConnectionString))
            //{
            //    var asd = db.Select<CustomTable>(selector: db.GetTable<Customer>(),);
            //}
                Console.WriteLine("HelloWorld, End");
        }
        private static void PrintCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.LastName} {customer.FirstName} \t{customer.Age}");
        }
        private static void PrintProducts(Product product)
        {
            Console.WriteLine($"{product.Id}, {product.Name} {product.Description} \t{product.StockQuantity} \t{product.Price}");
        }
        private static void PrintOrders(Order order)
        {
            Console.WriteLine($"{order.Id}, {order.Quantity} {order.ProductId} \t{order.CustomerId}");
        }
    }
    public static class LinqExt
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}