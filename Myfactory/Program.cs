using System;

namespace Myfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Wearhouse wh = new();
            Factory fa = new();
            wh.PrintInventory();
            fa.MarkOrder();

        }
    }
}
