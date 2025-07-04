using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.BL;

internal class ShippingCart
{
    private List<Product> products { get; set; } = new List<Product>();


    public void ShowCart()
    {
        if (products.Count() <= 0)
        {
            Console.WriteLine("Your cart is empty. please add some products");
            return;
        }

        Console.WriteLine("Shipping Cart: \n");
        foreach (var product in products)
        {
            product.PrintProduct();
            Console.WriteLine();
        }
    }

    public void Add(Product product)
    {
        products.Add(product);
    }

    public void Remove(string productName) {
        foreach (var product in products)
        {
            if(product.name == productName)
            {
                products.Remove(product);
                Console.WriteLine($"Product {product.name} was removed succussfully.");
                return;
            }
        }
        Console.WriteLine($"We not have any products with name {productName}");
    }

    public void Checkout()
    {
        if(products.Count() <= 0)
        {
            Console.WriteLine("Your cart is empty. please add some products");
            return;
        }
            
        Console.WriteLine("** Shipment Notice **");
        foreach (var product in products)
        {
            Console.Write($"{product.quantity}x ");
            product.PrintProduct();
        }


        Console.WriteLine("** Checkout receipt **");
        var subTotal = 0.0;
        var shippingPrice = 0.0;
        foreach (var product in products)
        {
            Console.WriteLine($"{product.quantity}x {product.name} { product.price * product.quantity}");
            subTotal += product.price * product.quantity;

            if (product is ShippableProduct product1)
                shippingPrice += product1.weight * 9;
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Subtotal \t {subTotal}");
        Console.WriteLine($"Shipping \t {shippingPrice}");
        Console.WriteLine($"Total \t {subTotal + shippingPrice}");

        products.Clear();
    }
}
