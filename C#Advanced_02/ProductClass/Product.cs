using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advanced_02.ProductClass
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        #region Task1 helper
        //We need to evaluate a condition on a Product and return a boolean indicating if it matches the filter
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new();
            foreach (var p in products)
            {
                if (filter(p))
                {
                    result.Add(p);
                }
            }
            return result;
        }
        #endregion
        #region Task3.1 helper
        //We want to execute a block of code for each product in the list, allowing the caller to define what that block of code does
        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (var p in products)
            {
                action(p);
            }
        } 
        #endregion
    }
}
