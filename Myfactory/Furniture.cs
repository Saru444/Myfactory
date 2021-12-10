using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    public abstract class Furniture
    {
        public string Name { get; set; }
        public Dictionary<string, int> Rrequired { get; set; }
        public abstract List<Iitem> RemoveMaterial(List<Iitem> sendToFactory, List<Iitem> inventory);
    }
}
