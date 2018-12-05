using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Table : Attribute
    {
        private string Name;

        public Table(string Name)
        {
            this.Name = Name;
        }

        public string name { get { return this.Name; } }
    }
}
