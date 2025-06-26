using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public Products(int productID, string productName, int categoryID, double unitPrice, int unitsInStock)
        {
            ProductID = productID;
            ProductName = productName;
            CategoryID = categoryID;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }
        public override string ToString()
        {
            return $"{ProductID}: {ProductName}, {CategoryID}, {UnitPrice:C}, {UnitsInStock} units in stock";
        }
    }
}
