namespace LinqGroupAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00M },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200.00M },
            new Product { Name = "Shirt", Category = "Clothing", Price = 30.00M },
            new Product { Name = "Jeans", Category = "Clothing", Price = 60.00M },
            new Product { Name = "Sneakers", Category = "Footwear", Price = 100.00M }
        };
            var productCountByCategory = products.GroupBy(p => p.Category)
                                             .Select(g => new { Category = g.Key, Count = g.Count() });

            Console.WriteLine("Number of products in each category:");
            foreach (var item in productCountByCategory)
            {
                Console.WriteLine($"{item.Category}: {item.Count}");
            }


            var totalPriceByCategory = products.GroupBy(p => p.Category)
                                               .Select(g => new { Category = g.Key, TotalPrice = g.Sum(p => p.Price) });

            Console.WriteLine("\nTotal price of products in each category:");
            foreach (var item in totalPriceByCategory)
            {
                Console.WriteLine($"{item.Category}: {item.TotalPrice:C}");
            }


            var mostExpensiveProductByCategory = products.GroupBy(p => p.Category)
                                                        .Select(g => new { Category = g.Key, MostExpensiveProduct = g.Max(p => p.Price) });

            Console.WriteLine("\nMost expensive product in each category:");
            foreach (var item in mostExpensiveProductByCategory)
            {
                Console.WriteLine($"{item.Category}: {item.MostExpensiveProduct:C}");
            }
        }
    }
}