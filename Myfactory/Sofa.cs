using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfactory
{
    class Sofa:Iproduct
    {
        public string Name { get; set; } = "Sofa";
        public Dictionary<string, int> _required;
        public Sofa()
        {
            _required = new Dictionary<string, int>();
            _required["wood"] = 3;
            _required["fabric"] = 2;
            _required["cushion"] = 6;
        }
        public void RemoveMaterial(List<Material> materials)
        {
            for (int i = 0; i < materials.Count; i++)
            {
                if (_required.ContainsKey(materials[i].Name))
                {
                    materials[i].Count -= _required.FirstOrDefault(x => x.Key == materials[i].Name).Value;
                }
                else
                {
                    break;
                }
            }
        }
        //public Dictionary<string,int> Required { get; set; } = new Dictionary<string, int>
        //{
        //    {"wood",3},
        //    {"fabric",2 },
        //    {"cushion",6}
        //};

        //public void RemoveMaterial(List<Material> materials)
        //{
        //    //foreach (var item in materials)
        //    //{
        //    //    materials.Remove(materials.Find(x => x.== item));
        //    //}
        //    materials.Remove();

        //}

    }
}
