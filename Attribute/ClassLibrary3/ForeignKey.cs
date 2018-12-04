using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    class ForeignKey:Attribute
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string References { get; private set; }

        public ForeignKey(string ID, string Name, string References)
        {
            this.ID = ID;
            this.Name = Name;
            this.References = References;
        }
    }
}
