using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class ManyOne : Relation
    {
        public ManyOne(string ID, string TableName) : base(ID, TableName)
        {
        }
    }
}
