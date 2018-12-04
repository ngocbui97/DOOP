using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Table : Attribute
    {
        public string Name { get; set; }

        public Table(string Name)
        {
            this.Name = Name;
        }
    }
}
