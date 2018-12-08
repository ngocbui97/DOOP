using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Attributes
{
    public class OneMany : Relation
    {
        public OneMany(string ID, string TableName) : base(ID, TableName)
        {
        }
    }
}
