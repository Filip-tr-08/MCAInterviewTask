using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpers
{
   public static class StatisticsHelper
    {
        public static void PrintStatistics(List<Product> products)
        {
            Console.WriteLine(TotalCost(products, true));
            Console.WriteLine(TotalCost(products, false));
            Console.WriteLine(TotalCount(products, true));
            Console.WriteLine(TotalCount(products, false));
        }

      private static string TotalCost(List<Product> products,bool isDomestic)
        {
            double costsSum = 0.00D;
            foreach(Product product in products)
            {
                if (product.Domestic == isDomestic)
                {
                    costsSum += product.Price;
                }
            }
            string costsSumString =String.Format("{0:0.00}",costsSum);
            string domesticOrImported = isDomestic ? "Domestic" : "Imported";
            return $"{domesticOrImported} cost: ${costsSumString}";

        }
    private static string TotalCount (List<Product> products, bool isDomestic)
        {
            int count = products.Where(x => x.Domestic == isDomestic).Count();
            string domesticOrImported = isDomestic ? "Domestic" : "Imported";
            return $"{domesticOrImported} count: {count}";
        }

    }
}
