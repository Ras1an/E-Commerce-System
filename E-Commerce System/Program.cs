using E_Commerce_System.BL;

namespace E_Commerce_System;






internal class Program
{
    static void Main(string[] args)
    {
        Database database = new Database();

        List<Product> systemProducts = database.DownloadDatabase();

        var customerBalance = 50000.0;


        EcommerceSystem ecommerceSystem = new EcommerceSystem(systemProducts, customerBalance);


        bool runLoop = true;
        while (runLoop)
        {


            Console.WriteLine($"Your Balance = {ecommerceSystem.customerBalance}\n");
            Console.WriteLine("1- Add A Product To Cart");
            Console.WriteLine("2- Show Shipping Cart");
            Console.WriteLine("3- Checkout");
            Console.Write("Your Choice: ");

            string choice = Console.ReadLine(); 


            if(choice == "1")
            {
                Console.WriteLine("\n\n");

                ecommerceSystem.BuyProduct();
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n\n");

                ecommerceSystem.ShowChart();
            }
            else if (choice == "3")
            {
                Console.WriteLine("\n\n");

                ecommerceSystem.Checkout();
            }

            else
            {
                Console.WriteLine("\n\n");

                Console.WriteLine("Invalid Input! please Try Again");
            }
            database.UploadDatabase(ecommerceSystem.systemProducts.GetSystemProducts());

            Console.WriteLine("\n\n\n");

        }
    }
}
