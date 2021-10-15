using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Product
    {
        public string Name { get; set; }
        public bool Domestic { get; set; }
        public double Price { get; set; }
        public double? Weight { get; set; }
        public string Description { get; set; }

        public void PrintProduct()
        {
            Console.WriteLine($"... {char.ToUpper(Name[0])+Name.Substring(1)}");
            Console.WriteLine($"   Price: ${PriceFormat()}");
            Console.WriteLine($"   {DescriptionTruncate()}");
            Console.WriteLine($"   Weight: {WeightFormat()}");
        }
        private string DescriptionTruncate()
        {
            return Description.Trim().Length < 10 ? Description : $"{Description.Trim().Substring(0,10)}...";
        }
        private string PriceFormat()
        {
            return String.Format("{0:0.0}", Price);
        }
        private string WeightFormat()
        {
            return Weight != null ? $"{Weight}g" : "N/A";
        }
    }
}
