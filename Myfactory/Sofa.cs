using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Sofa : Iproduct
    {
        public string Name { get; set; } = "SOfa";
        public Hashtable Required { get; set; } = new Hashtable
        {
            {"wood",3},
            {"fabric",2 },
            {"cushion",6}
        };

        public List<Iproduct> RemoveMaterial(List<Material> materials)
        {
            foreach (var item in materials)
            {
                materials.Remove(materials.Find(x => x.Count == item.Count));
            }
            
        }

        public List<Iproduct> RemoveMMaterial()
        {
            throw new NotImplementedException();
        }
    }
}
