

using Dapper.Data.DapperServices;

public class Program
{
    static void Main(string[] args)
    {
        DapperServices dapperServices = new DapperServices();
        Console.WriteLine("Products List:");
        dapperServices.Read();
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Creating a new product...");
        dapperServices.Create();
        dapperServices.Read();
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Update a product...");
        dapperServices.Update();
        dapperServices.Read();
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Delete a product...");
        dapperServices.Delete();
        dapperServices.Read();
        Console.WriteLine("----------------------------------------");

    }
}
