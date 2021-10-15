using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpers
{
    public static class ProductHelper
    {
        private static ProductServices productServices = new ProductServices();
        public static void PrintRecipe()
        {
            List<Product> products = GetProducts();
            Console.WriteLine(". Domestic");
            products.Where(x => x.Domestic == true).ToList().Print();
            Console.WriteLine(". Imported");
            products.Where(x => x.Domestic == false).ToList().Print();
            StatisticsHelper.PrintStatistics(products);
        }
        private static void Print(this List<Product> products)
        {
            foreach (Product product in products)
            {
                product.PrintProduct();
            }
        }
        private static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            foreach (Product product in productServices.GetAllProducts())
            {
                products.Add(product);
            }
           List<Product> sortedProduct= SortedProducts(products);
            return sortedProduct;
        }
       private static List<Product> SortedProducts(List<Product> products)
        {
            return products.OrderBy(x => x.Name).ToList();
        }
    }
}
