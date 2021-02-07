using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace OOP1
{

    public static class ProductManager
    {
      public void Add(Product product)
      {
      	Console.WriteLine(product.ProductName + "eklendi.");
      }
      
      public void Update(Product product)
      {
      	Console.WriteLine(product.ProductName + "güncellendi.");
      }
    }
}