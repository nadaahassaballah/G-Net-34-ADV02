using System.Runtime.InteropServices;

namespace G_Net_34_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };
            #region task1

            List<Product> electronics = SearchProducts(catalog, p => p.Category == "Electronics");
            List<Product> under50p = SearchProducts(catalog, p => p.Price < 50);
            List<Product> instock = SearchProducts(catalog, p => p.Stock > 0);
            List<Product> cheaperclotes = SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);

            Console.WriteLine("electronics");
            print(electronics);
            Console.WriteLine("under50p");
            print(under50p);


            Console.WriteLine("instock");
            print(instock);
            Console.WriteLine("cheaperclotes");
            print(cheaperclotes);



            #endregion
            #region task2
            Console.WriteLine("short report");
            printreport(catalog, p => Console.WriteLine($"{p.Name}_ ${p.Price}"));
            Console.WriteLine("detailed report");
            printreport(catalog, p => Console.WriteLine($"[{p.Category}]{p.Name}| ${p.Price}|{p.Stock}"));

            #endregion
        }
        public static void print(List<Product> list)
        {
            foreach (var p in list)
            {
                Console.WriteLine($"{p.Name} - {p.Category} - {p.Price}$ - Stock: {p.Stock}");
            }
        }
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            return products.Where(filter).ToList();
        }
        public static void printreport(List<Product> products, Action<Product> action)
        {
            foreach (var item in products)
            {
                action(item);
            }
        }
        

    }
}
