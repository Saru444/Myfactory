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
        List<Material> RemoveMaterial(List<Material> materials);
    }
}
