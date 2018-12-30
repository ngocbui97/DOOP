using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.PropertySQL
{
    public class OneMany : Relation
    {
        //public string RelationshipID { get; set; }
        //public string nameTable { get; set; }

        public OneMany(string RelationID, string NameTableRelation) : base(RelationID, NameTableRelation)
        {
        }

    }
}
