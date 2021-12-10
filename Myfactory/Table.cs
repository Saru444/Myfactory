using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Table:Furniture,Iitem
    {
        public Dictionary<string, int> Required = new();
        public Table()
        {
            this.Name = "table";
            Required["wood"] = 2;
        }
        public override List<Iitem> RemoveMaterial(List<Iitem> sendToFactory, List<Iitem> inventory)
        {
            foreach (var post in Required)
            {
                for (int i = 0; i < post.Value; i++)
                {
                    sendToFactory.Remove(sendToFactory.Find(x => x.Name == post.Key));
                    inventory.Add(new Table());
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
