using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Attributes
{
    public class Relation:Attribute
    {
        protected string ID;
        protected string TableName;

        public Relation(string ID, string TableName)
        {
            this.ID = ID;
            this.TableName = TableName;
        }

        public string id { get { return this.ID; } }
        public string tabname { get { return this.TableName; } }
    }
}
