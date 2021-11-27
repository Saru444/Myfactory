using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Table:Iproduct
    {
        public string Name { get; set; } = "Dining table";
        public Dictionary<string, int> _required;
        public Table()
        {
            _required = new Dictionary<string, int>();
            _required["wood"] = 2;
        }
        public List<Material> RemoveMaterial(List<Material> materials)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (_required.ContainsKey(materials[i].Name))
                {
                    materials[i].Count -= _required.FirstOrDefault(x => x.Key == materials[i].Name).Value;
                }            
            }
            return materials;
        }
    }
  
}
