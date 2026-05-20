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

