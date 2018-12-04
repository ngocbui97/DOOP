using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    class PrimaryKey:Attribute
    {
        public string Name { get; private set; }
        public bool Auto { get; private set; }

        public PrimaryKey(string Name, bool Auto)
        {
            this.Name = Name;
            this.Auto = Auto;
        }
    }
}
