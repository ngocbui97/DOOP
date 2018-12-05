using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Relation:Attribute
    {
        protected string ID;
        protected string TableName;
        protected string _Relation;

        public static string OneOne = "11";
        public static string OneMany = "1n";
        public static string ManyOne = "n1";

        public Relation(string ID, string TableName, string relation)
        {
            this.ID = ID;
            this.TableName = TableName;
            this._Relation = relation;
        }

        public string id { get { return this.ID; } }
        public string tabname { get { return this.TableName; } } 
        public string relation { get { return this._Relation; } }
    }
}
