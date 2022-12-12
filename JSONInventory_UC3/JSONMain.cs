using JSONInventory_UC3;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONInventory_UC1
{
    internal class JSONMain
    {
        stockPortfolio Inventory = new stockPortfolio();
        List<stockPortfolio> InventoryList = new List<stockPortfolio>();
        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<stockPortfolio>>(json);
                Console.WriteLine("name weight price total value");
                foreach (var item in items)
                {
                    Double value = item.NumberOfShare * item.SharePrice;
                    Console.WriteLine(item.StockName + " " + item.SharePrice + " " + item.NumberOfShare + " " + value);

                }
            }
        }
    }
}
