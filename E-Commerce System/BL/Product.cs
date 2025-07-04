using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Commerce_System.BL;

internal class Product
{
    public string name { get; set; }
    public double price { get; set; }

    public int quantity { get; set; }


    public Product()
    {
        
    }
    public Product(string _name, double _price, int _quantity)
    {
        name = _name;
        price = _price;
        quantity = _quantity;  
    }

    public virtual Product Clone(int purchasedQuantity)
    {
        return new Product
        {
            name = this.name,
            price = this.price,
            quantity = purchasedQuantity
        };
    }


    public virtual void PrintProduct() {
        Console.WriteLine($"Product Name: {name} \t Price: {price}");
    }


    public override string ToString()
    {
        return $"{name},{price},{quantity}";
    }
}
