using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.BL;

internal class SystemProducts
{
    private List<Product> products {get; set;} = new List<Product>();  


    public void SetSystemProducts(List<Product> _products)
    {
        products = _products;
    }

    public double GetProductPrice(int index)
    {
        return products[index].price;

    }

    public List<Product> GetSystemProducts()
    {
        return products;
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
        Console.WriteLine($"{product.name} with {product.quantity} items was added");
    }
    public void ShowAllProducts()
    {
        Console.WriteLine("All System Products: \n");
        for (int i = 0; i < products.Count(); i++)
        {
            Console.Write($"{i + 1}- ");
            products[i].PrintProduct();
        }
    }

    public Product DecreaseProduct(int productId, int productQuantity)
    {
        if (products[productId - 1].quantity >= productQuantity)
        {
            Product purshasedProduct = products[productId - 1].Clone(productQuantity);
            if (purshasedProduct is ExpirableProduct product1) {
                if(product1.isExpired == true)
                {
                    return null;
                }
            }



            products[productId - 1].quantity -= productQuantity;

            return products[productId - 1].Clone(productQuantity);
        }

        return null;
    }
}