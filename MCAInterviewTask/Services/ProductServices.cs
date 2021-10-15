using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services
{
   public class ProductServices
    {
        private string _productsJson = "https://interview-task-api.mca.dev/qr-scanner-codes/alpha-qr-gFpwhsQ8fkY1";


        public List<Product> GetAllProducts()
        {
            return Read();
        }

        private List<Product> Read()
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    string content = webClient.DownloadString(_productsJson);
                    return JsonConvert.DeserializeObject<List<Product>>(content);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
