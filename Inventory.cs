using System.Collections.Generic;
namespace InventoryManagement
{
    class Inventory
    {
        public IList<Rice> Rice { get; set; }
        public IList<Wheats> Wheats { get; set; }
        public IList<Pulses> Pulses { get; set; }
    }
    public class Rice
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
    public class Wheats
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
    public class Pulses
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
    }
}