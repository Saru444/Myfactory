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
        public Hashtable Required { get; set; } = new Hashtable
        {
            {"wood",2}
        };

        public List<Iproduct> RemoveMMaterial()
        {
            throw new NotImplementedException();
        }
    }
  
}
