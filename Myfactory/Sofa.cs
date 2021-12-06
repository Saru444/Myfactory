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
        public override List<Material> RemoveMaterial(List<Material> materials)
        {
            foreach (var post in Required)
            {
                for (int i = 0; i < post.Value; i++)
                {
                    materials.Remove(materials.Find(x => x.Name == post.Key));
                }
            }
            return materials;
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
