using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.PropertySQL
{
    public class ManyOne : Relation
    {
        //public string RelationshipID { get; set; }
        //public string nameTable { get; set; }

        public ManyOne(string RelationID, string NameTableRelation) : base(RelationID, NameTableRelation)
        {
        }

    }
}
