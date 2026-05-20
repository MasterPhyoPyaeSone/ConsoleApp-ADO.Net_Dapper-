
using AdoNetApp.Data;

namespace AdoNetApp
{
    class Program
    {
        static void Main(string[] args)
        {

            AdoNetAppService  adoNetAppService = new AdoNetAppService();

            Console.WriteLine("Products List:");
            adoNetAppService.Read();
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Creating a new product...");
            adoNetAppService.Create();
            Console.WriteLine("After Create Products List:");
            adoNetAppService.Read();
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Updating the product...");
            adoNetAppService.Update();
            Console.WriteLine("After Update Products List:");
            adoNetAppService.Read();
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Products Deleted...");
            adoNetAppService.Delete();
            Console.WriteLine("After Delete Products List:");
            adoNetAppService.Read();
            Console.WriteLine("----------------------------------------");

            
        }
    }
}

