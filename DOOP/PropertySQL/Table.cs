using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.PropertySQL
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
