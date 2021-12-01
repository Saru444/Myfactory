using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Wearhouse
    {
        private List<Iitem> _inventory;
        private List<Iitem> _sendToFactory;
        private List<Material> _materials = new();
        public Wearhouse()
        {
            _inventory = new();
            _sendToFactory = new();
            _materials.Add(new Material { Name = "wood" });
            _materials.Add(new Material { Name = "fabric" });
            _materials.Add(new Material { Name = "cushion" });
        }
        public void Stock(List<Material> materials)
        {
            for (int i = 0; i < 15; i++)
            {
                if(_inventory.Find(x=>x.Name==materials))
                {
                    _inventory.Add(materials);
                }              
            }
        }
        public List<Iitem> PickUp()
        {
            while (true)
            {
                Console.WriteLine("Which item do you want?");
                string input = Console.ReadLine();
                if (_inventory.Find(x => x.Name == input))
                {
                    _inventory.Remove(_inventory.Find(x => x.Name == input));
                    _sendToFactory.Add(_sendToFactory.Find(x => x.Name == input));
                }
                else
                {
                    Console.WriteLine("It's running out of stock");
                }
                Console.WriteLine("Do you want to send them to factory,push Space");
                if(Console.ReadKey().Key==ConsoleKey.Spacebar)
                {
                    return _sendToFactory;
                }
            }
        }
        public void PrintInventory()
        {
            Console.WriteLine("Wearhouse List");
            Console.WriteLine("--------------");
            foreach (var item in _inventory)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
    }
}
