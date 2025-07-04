using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.BL;

internal class ExpirableProduct : Product
{
    public bool isExpired { get; set; }


    public ExpirableProduct()
    {
        
    }
    public ExpirableProduct(string _name, double _price, int _quantity, bool _isExpired = false) : base(_name, _price, _quantity)
    {
        isExpired = _isExpired;
    }


    public override Product Clone(int purchasedQuantity)
    {
        return new ExpirableProduct
        {
            name = this.name,
            price = this.price,
            quantity = purchasedQuantity,
            isExpired = this.isExpired
        };
    }

    public override void PrintProduct()
    {
        Console.Write($"Product Name: {name} \t Price: {price} \t");

        var expired = isExpired ? "Expired" : "Fresh Product";

        Console.WriteLine($"\t {expired}");
    }


    public override string ToString()
    {
        return $"{name},{price},{quantity},{isExpired}";
    }
}
