using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.BL;

internal class Database
{


    private Product ToProduct(string line)
    {
        var productStrings = line.Split(',');

        if(productStrings.Count() == 3) { 
            return new Product {
            name = productStrings[0],
            price = Convert.ToDouble(productStrings[1]),
            quantity = Convert.ToInt32(productStrings[2]),

        };
        }

        else
        {
            if (productStrings[3].Trim().ToLower() == "true" || productStrings[3].Trim().ToLower() == "false")
            {
                return new ExpirableProduct
                {
                    name = productStrings[0],
                    price = Convert.ToDouble(productStrings[1]),
                    quantity = Convert.ToInt32(productStrings[2]),
                    isExpired = Convert.ToBoolean(productStrings[3].Trim()),
                };
            }

            return new ShippableProduct
            {
                name = productStrings[0],
                price = Convert.ToDouble(productStrings[1]),
                quantity = Convert.ToInt32(productStrings[2]),
                weight = Convert.ToDouble(productStrings[3].Trim()),
            };
        }
    }
    public List<Product> DownloadDatabase()
    {
        List<Product> products = new List<Product>();
        using (StreamReader reader = new StreamReader("Data.txt"))
        {
            string line ;

            while((line = reader.ReadLine()) != null)
            {
                Product product = ToProduct(line);

                products.Add(product);
            }
        }

        return products;
    }


    public void UploadDatabase(List<Product> products)
    {
        using (StreamWriter writer = new StreamWriter("data.txt"))
        {
            foreach (Product product in products)
            {

                writer.WriteLine(product.ToString());
            }
        }

    }
}
