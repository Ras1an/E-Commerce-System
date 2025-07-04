using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.BL;

internal class EcommerceSystem
{

    
    public SystemProducts systemProducts { get; set; } = new SystemProducts();
    public ShippingCart cart { get; set; } = new ShippingCart();
    public double customerBalance;

    public EcommerceSystem(List<Product> products, double _customerBalance)
    {
        systemProducts.SetSystemProducts(products);
        customerBalance = _customerBalance;
    }
    public void AddProduct(Product product)
    {
        systemProducts.AddProduct(product);
    }
    public void BuyProduct()
    {
        systemProducts.ShowAllProducts();


        Console.Write("Choose a product number: ");
        int productChoice = Convert.ToInt32(Console.ReadLine());

        Console.Write("How much quantity you want to buy: ");
        int productQuantity = Convert.ToInt32(Console.ReadLine());


        double totalCost = systemProducts.GetProductPrice(productChoice - 1) * productQuantity;

        if ( totalCost > customerBalance)
        {
            Console.WriteLine("You have not sufficient balance to build");
            return;
        }

        var purchasedProduct = systemProducts.DecreaseProduct(productChoice, productQuantity);

        if (purchasedProduct != null)
        {
            cart.Add(purchasedProduct);
            customerBalance -= totalCost;
            Console.WriteLine($"We add {purchasedProduct.quantity} items of product {purchasedProduct.name} to cart");
        }
        else
        {
            Console.WriteLine("Sorry, we do not have sufficient quantity of this product now or the product may be expired");
        }
    }
    // Add & Remove products from cart with the avaiable qunatity

    // Checkout

    public void ShowChart()
    {
        cart.ShowCart();
    }
    public void Checkout()
    {
        cart.Checkout();
    }
}
