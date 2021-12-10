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
        //private List<Material> _materials = new();
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
                while (_inventory.FindAll(x => x.Name == item).Count < 15)
                {
                    _inventory.Add(new Material { Name = item });
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
                if (_inventory.FindAll(x => x.Name == input).Count >= amount)
                {
                    UserChoice(input, amount);
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
        public void Produce()
        {
            Title();
            int choice = TryParse();
            switch (choice)
            {
                case 1:
                    Furniture table = new Table();
                    table.RemoveMaterial(_inventory);
                    break;
                case 2:
                    Furniture sofa = new Sofa();
                    sofa.RemoveMaterial(_inventory);
                    break;
            }
        }
        //public void PrintInventory()
        //{
        //    Console.WriteLine("Wearhouse List");
        //    Console.WriteLine("--------------");
        //    foreach (var item in _typenames)
        //    {
        //        Console.WriteLine($"{item}");
        //    }
        //}
        private int TryParse()
        {
            int input;
            while (int.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.WriteLine("you haven't entered a correct integer, try again");
            }
            return input;
        }
        public void Title()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"____ ____ ____ ____ ____ ____ ____            ");
            Console.WriteLine(@"||F |||A |||C |||T |||O |||R |||Y ||           ");
            Console.WriteLine(@"||__|||__|||__|||__|||__|||__|||__||          ");
            Console.WriteLine(@"|/__\|/__\|/__\|/__\|/__\|/__\|/__\|          ");
            Console.WriteLine("                                                ");
            Console.ResetColor();
            Console.WriteLine("Which product do you want to order?");
            Console.WriteLine("[1] Dining table");
            Console.WriteLine("[2]. Sofa");
            Console.WriteLine("[3]. Exit");
        }
    }
}
