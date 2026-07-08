using EFCoreCodeFirstApproach.Data;
using EFCoreCodeFirstApproach.Models;

namespace EFCoreCodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext _context = new ProductDBContext();

            //List all products
            Console.WriteLine("List of Products:");
            _context.Products.ToList().ForEach(p => Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Price: {p.Price}"));

            //Add a new product
            Console.WriteLine("\nAdding a new product...");
            Product prod = new Product()
            {
                Name = "New Product",
                Price = 99.99f,
                Description = "This is a new product."
            };
            _context.Products.Add(prod);

            //Save changes to the database
            _context.SaveChanges();

            //Update a product
            _context.Products.Update(new Product()
            {
                Id = 1,
                Name = "Updated Product",
                Price = 199.99f,
                Description = "This is an updated product."
            });
            _context.SaveChanges();

            //Delete a product
            _context.Products.Remove(new Product() { Id = 1 });

        }
    }
}
