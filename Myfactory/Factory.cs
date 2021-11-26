using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Factory
    {
        
        public void MarkOrder()
        {
            Title();
            int input = Tryparse();
            Console.WriteLine("How many do you want to order ");
            int count = Tryparse();
            

        }
        public void Title()
        {
            Console.WriteLine("");
            Console.WriteLine(@"____ ____ ____ ____ ____ ____ ____            ");
            Console.WriteLine(@"||F |||A |||C |||T |||O |||R |||R ||           ");
            Console.WriteLine(@"||__|||__|||__|||__|||__|||__|||__||          ");
            Console.WriteLine(@"|/__\|/__\|/__\|/__\|/__\|/__\|/__\|          ");
            Console.WriteLine("                                                ");
            Console.WriteLine("Which product do you want to order?");
            Console.WriteLine("[1] Dining table");
            Console.WriteLine("[2]. Sofa");
            Console.WriteLine("[3]. Exit");
        }
        private int Tryparse()
        {
            int input = 0;
            while (int.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.WriteLine("you haven't entered a correct integer, try again");
            }
            return input;
        }

    }
}
