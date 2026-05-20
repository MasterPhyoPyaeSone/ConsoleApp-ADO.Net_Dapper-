using EFCoreApp.AppDbContextModels;
using EFCoreApp.Data;
using Microsoft.Identity.Client;


public class Program
{
    static void Main(string[] args)
{
    EFCoreServices eFCoreServices = new EFCoreServices();

        Console.WriteLine("Products List:");
        eFCoreServices.Read();
         Console.WriteLine("----------------------------------------");

         Console.WriteLine("Creating a new product...");
         eFCoreServices.Create();
         Console.WriteLine("After Create Products List:");
         eFCoreServices.Read();
         Console.WriteLine("----------------------------------------");

         Console.WriteLine("Updating the product...");
         eFCoreServices.Update();
         Console.WriteLine("After Update Products List:");
         eFCoreServices.Read();
         Console.WriteLine("----------------------------------------");

         Console.WriteLine("Products Deleted...");
         eFCoreServices.Delete();
         Console.WriteLine("After Delete Products List:");
         eFCoreServices.Read();
         Console.WriteLine("----------------------------------------");
}
}

// using (var context = new AppDbContext())
// {

//     Console.WriteLine("All Products List:");
//     var products = context.Products.ToList();
//     foreach (var p in products)
//     {
//         Console.WriteLine($"ID: {p.Id} | Name: {p.Name} | Price: ${p.Price} | Qty: {p.Quantity}");
//     }
//     Console.WriteLine("-----------------------------------------\n");


//     Console.WriteLine("Adding a new product");
//     var newProduct = new Product
//     {
//         Name = "Gaming Laptop",
//         Price = 1500.50m,
//         Quantity = 10
//     };
//     context.Products.Add(newProduct);
//     context.SaveChanges();
//     Console.WriteLine("Product Added successfully.");
//     Console.WriteLine("-----------------------------------------\n");


//     Console.WriteLine("Update the product");
//     var productToUpdate = context.Products.FirstOrDefault(p => p.Name == "Gaming Laptop");

//     if (productToUpdate != null)
//     {
//         productToUpdate.Price = 1400.00m;
//         productToUpdate.Quantity = 8;

//         context.SaveChanges();
//         Console.WriteLine("Product updated successfully.");
//         Console.WriteLine("-----------------------------------------\n");

//     }

//     Console.WriteLine("Delete the product");
//     var productToDelete = context.Products.FirstOrDefault(p => p.Name == "Gaming Laptop");

//     if (productToDelete != null)
//     {
//         context.Products.Remove(productToDelete);
//         context.SaveChanges();
//         Console.WriteLine("Product deleted successfully.");
//     }
// }
