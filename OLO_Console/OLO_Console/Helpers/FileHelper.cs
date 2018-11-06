using Newtonsoft.Json;
using OLO_Console.DTO;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace OLO_Console.Helpers
{
    public class FileHelper
    {
        private const string filePath = "http://files.olo.com/pizzas.json";
        private const string fileName = "pizzas.json";

        public List<PizzaTopping> GetToppingsList()
        {
            WebClient cln = new WebClient();

            if (!File.Exists(fileName))
                cln.DownloadFile(filePath, fileName);

            StreamReader file = new StreamReader(fileName);
            string jsonContent = file.ReadToEnd();

            return JsonConvert.DeserializeObject<List<PizzaTopping>>(jsonContent);
        }
    }
}
