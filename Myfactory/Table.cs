using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Table
    {
        public string Name { get; set; } = "Dining table";
        public Dictionary<string, int> required;
        public Table()
        {
            required = new Dictionary<string, int>;
            required["wood"] = 2;
        }

        public void RemoveMMaterial(List<Material> materials)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (required.ContainsKey(materials[i].Name))
                {
                    materials[i].Count -= required.FirstOrDefault(x => x.Key == materials[i].Name).Value;
                }
            }
        }
    }
  
}
