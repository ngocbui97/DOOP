using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.PropertySQL
{
    public class PrimaryKey:Attribute
    {
        private string Name;
        private bool Auto;

        public PrimaryKey(string Name, bool Auto)
        {
            this.Name = Name;
            this.Auto = Auto;
        }

        public string name { get { return this.Name; } }
        public bool auto { get { return this.Auto; } }
    }
}
