using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Sofa: Furniture,Iitem
    {
        public Dictionary<string, int> Required = new();
        public Sofa()
        {
            this.Name = "sofa";
            Required["wood"] = 3;
            Required["fabric"] = 2;
            Required["cushion"] = 6;
        }    
        public override List<Iitem> RemoveMaterial(List<Iitem> inventory)
        {
            foreach (var post in Required)
            {
                for (int i = 0; i < post.Value; i++)
                {
                    inventory.Remove(inventory.Find(x => x.Name == post.Key));
                }
            }
            return inventory;
        }













        //public List<Material> RemoveMaterial(List<Material> materials)
        //{
        //    for (int i = 0; i < materials.Count; i++)
        //    {
        //        if (_required.ContainsKey(materials[i].Name))
        //        {
        //            materials[i].Count -= _required.FirstOrDefault(x => x.Key == materials[i].Name).Value;
        //        }          
        //    }
        //    return materials;
        //}


    }
}
