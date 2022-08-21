using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace InventoryManagement
{
    class InventoryManagement
    {
        public IList<Rice> Rice { set; get; }
        public IList<Pulses> Pulses
        {
            set;
            get;
        }
        public IList<Wheats> Wheats { set; get; }
        public static void Inventorymanagement()
        {
            Inventory inventory = new Inventory();

            double totalriceprice = 0.0;
            double totalwheatprice = 0.0;
            double totalpulsesprice = 0.0;
            string json = @"C:\Users\bagav\saran\visual studio\Day10\Day10AddressBook\InventoryManagement\Inventory.json";
            try
            {
                string jsonfile = File.ReadAllText(json);
                InventoryManagement inventoryManagement = (InventoryManagement)JsonConvert.DeserializeObject(jsonfile, typeof(InventoryManagement));
                foreach (Rice objerice in inventoryManagement.Rice)
                {
                    string name = objerice.Name;
                    double price = objerice.Price;
                    double weight = objerice.Weight;

                    totalriceprice = totalriceprice + price * weight;
                    Console.WriteLine("objerice name" + name);
                    Console.WriteLine("objerice price" + price);
                    Console.WriteLine("objerice weight" + weight);
                }
                foreach (Pulses objepulses in inventoryManagement.Pulses)
                {
                    string name = objepulses.Name;
                    double price = objepulses.Price;
                    double weight = objepulses.Weight;

                    totalpulsesprice = totalpulsesprice + price * weight;
                    Console.WriteLine("objerpulses" + name);
                    Console.WriteLine("objecrpulses" + price);
                    Console.WriteLine("objepulses" + weight);
                }
                foreach (Wheats objwheats in inventoryManagement.Wheats)
                {
                    string name = objwheats.Name;
                    double price = objwheats.Price;
                    double weight = objwheats.Weight;

                    totalwheatprice = totalwheatprice + price * weight;
                    Console.WriteLine("objewheats" + name);
                    Console.WriteLine("objewheats" + price);
                    Console.WriteLine("objewheats" + weight);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
