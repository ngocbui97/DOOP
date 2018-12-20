using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.PropertySQL
{
    class ForeignKey:Attribute
    {
        private string ID;
        private string Name;
        private string References;

        public ForeignKey(string ID, string Name, string References)
        {
            this.ID = ID;
            this.Name = Name;
            this.References = References;
        }

        public string id { get { return this.ID; } }
        public string name { get { return this.Name; } }
        public string references { get { return this.References; } }
    }
}
