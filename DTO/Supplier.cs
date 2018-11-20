using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Supplier
    {
        public string id { get; set; }
        public string name { get; set; }
        public Supplier(string ID, string Name)
        {
            this.id = ID;
            this.name = Name;
        }
    }
}
