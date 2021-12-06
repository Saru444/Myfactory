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
        private List<string> _typenames;
        private List<Material> _materials = new();
        public Wearhouse()
        {
            _inventory = new();
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
        public void UserChoice(string typename, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _inventory.Remove(_inventory.Find(x => x.Name == typename));
                _sendToFactory.Add(new Material() { Name = typename });
            }
        }
        public List<Iitem> PickUp()
        {
            while (true)
            {
                Console.WriteLine("Which item do you want?");
                string input = Console.ReadLine();
                Console.WriteLine("How many do you want?");
                int amount = TryParse();
                if (_inventory.FindAll(x=>x.Name==input).Count>=amount)
                {
                    UserChoice(input,amount);
                }
                else
                {
                    Console.WriteLine("It's running out of stock");
                }
                Console.WriteLine("Do you want to send them to factory,push \"space\".");
                if (Console.ReadKey().Key == ConsoleKey.Spacebar)
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
        private int TryParse()
        {
            int input;
            while (int.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.WriteLine("you haven't entered a correct integer, try again");
            }
            return input;
        }
    }
}
