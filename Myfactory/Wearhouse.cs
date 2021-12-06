using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Wearhouse
    {
        private List<string> _typenames;
        private List<Iitem> _sendToFactory;
        private List<Material> _materials = new();
        public Wearhouse()
        {
            _typenames = new List<string>() { "Wood", "cushion", "fabric" };
            _sendToFactory = new();
            Stock();
        }
        public void Stock()
        {
            foreach (var item in _typenames)
            {
                while (_materials.FindAll(x => x.Name == item).Count < 15)
                {
                    _materials.Add(new Material { Name = item });
                }
            }
        }
        public List<Iitem> PickUp()
        {
            while (true)
            {
                Console.WriteLine("Which item do you want?");
                string input = Console.ReadLine();
                if (_typenames.Find(x => x.Name == input))
                {
                    _typenames.Remove(_typenames.Find(x => x.Name == input));
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
            foreach (var item in _typenames)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
