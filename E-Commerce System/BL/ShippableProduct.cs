using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.BL;

internal class ShippableProduct : Product
{
    public double weight { get; set; }

    public ShippableProduct()
    {
        
    }
    public ShippableProduct(string _name, double _price, int _quantity, double _weight) : base(_name, _price, _quantity)
    {
        weight = _weight;
    }

    public override Product Clone(int purchasedQuantity)
    {
        return new ShippableProduct
        {
            name = this.name,
            price = this.price,
            quantity = purchasedQuantity,
            weight = this.weight
        };
    }
    public override void PrintProduct()
    {
        Console.WriteLine($"Product Name: {name} \t Price: {price} \t Weight: {weight}");
    }

    public override string ToString()
    {
        return $"{name},{price},{quantity},{weight}";
    }
}
