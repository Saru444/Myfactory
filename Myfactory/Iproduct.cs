using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Myfactory
{
    interface Iproduct
    {
        public string Name { get; set; }
        void RemoveMaterial(List<Material> materials);
    }
}
