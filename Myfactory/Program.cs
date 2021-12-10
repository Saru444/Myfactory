using System;

namespace Myfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Wearhouse wh = new();
            wh.PrintInventory();
            wh.PickUp();
            //wh.Produce();

        }
    }
}
