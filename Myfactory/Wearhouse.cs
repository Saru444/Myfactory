using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Wearhouse
    {
        private static List<Material> _materials = new();
        private List<Iproduct> _productions = new();
        public Wearhouse()
        {
            _materials.Add(new Material { Name = "wood", Count = 10 });
            _materials.Add(new Material { Name = "fabric", Count = 10 });
            _materials.Add(new Material { Name = "cushion", Count = 15 });
        }
        public void Inventory()
        {

        }
        public void PrintInventory()
        {
            Console.WriteLine("Wearhouse List");
            Console.WriteLine("--------------");
            foreach (var item in _materials)
            {
                Console.WriteLine($"{item.Name}----{item.Count}");
            }
        }      
    }
}
