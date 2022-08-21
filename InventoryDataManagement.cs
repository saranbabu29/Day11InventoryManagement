using System;
namespace InventoryManagement
{
    class InventoryDataManagement
    {
        public void Inventorydatamanagement()
        {
            InventoryData inventoryData = new InventoryData();
            Console.WriteLine("Enter the choice :");
            Console.WriteLine("1.GetUserDetails:");
            Console.WriteLine("2.AddItem:");
            Console.WriteLine("3.Update Item:");
            Console.WriteLine("4.Delete Item:");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    inventoryData.GetUserDetails();
                    break;
                case 2:
                    inventoryData.AddItem();
                    break;
                case 3:
                    inventoryData.UpdateFile();
                    break;
                case 4:
                    inventoryData.DeleteItem();
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}