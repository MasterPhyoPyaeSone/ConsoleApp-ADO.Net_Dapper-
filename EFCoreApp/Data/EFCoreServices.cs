
using EFCoreApp.AppDbContextModels;

namespace EFCoreApp.Data
{
    public class EFCoreServices
    {
        AppDbContext context = new AppDbContext();

        public void Read()
        {

            var products = context.Products.ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.Id} | Name: {p.Name} | Price: ${p.Price} | Qty: {p.Quantity}");
            }


        }

        public void Create()
        {

            var newProduct = new Product
            {
                Name = "HP Laptop",
                Price = 2800.50m,
                Quantity = 25
            };
            context.Products.Add(newProduct);
            context.SaveChanges();
            Console.WriteLine("Product Added successfully.");
        }


        public void Update()
        {

            var productToUpdate = context.Products.FirstOrDefault(x => x.Name == "HP Laptop");
            if (productToUpdate != null)
            {
                productToUpdate.Price += 200;
                context.SaveChanges();
                Console.WriteLine("Product Updated successfully.");
            }
            else
            {
                Console.WriteLine("No products found to update.");
            }

        }


        public void Delete()
        {

            var productToDelete = context.Products.FirstOrDefault(x => x.Name == "HP Laptop");
            if (productToDelete != null)
            {

                context.Products.Remove(productToDelete);
                context.SaveChanges();
                Console.WriteLine("Product Deleted successfully.");
            }
            else
            {
                Console.WriteLine("No products found to delete.");
            }

        }

    }
}