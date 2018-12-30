using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.PropertySQL
{
    public abstract class Relation:Attribute
    {
        protected string RelationID;
        protected string NameTableRelation;

        public Relation(string RelationID, string NameTableRelation)
        {
            this.RelationID = RelationID;
            this.NameTableRelation = NameTableRelation;
        }

        public string relationId { get { return this.RelationID; } }
        public string nameTableRelation { get { return this.NameTableRelation; } }
    }
}
