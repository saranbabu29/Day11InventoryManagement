using System;
namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Any 1 option ");
            Console.WriteLine("1 : Inventory Data");
            Console.WriteLine("2 : Inventory Management");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
                    inventoryDataManagement.Inventorydatamanagement();
                    break;
                case 2:
                    InventoryManagement.Inventorymanagement();
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
