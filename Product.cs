using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace OOP1
{

    public static class Product
    {
    	public int Id { get; set; }
    	
    	public string ProductName { get; set; }
    	
    	public double UnitPrice { get; set; }
    	
    	public int CategoryId { get; set; }
    	
    	public int UnitsInStock { get; set; }
    	
    }
}