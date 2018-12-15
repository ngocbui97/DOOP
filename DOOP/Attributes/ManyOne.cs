﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Attributes
{
    public class ManyOne : Relation
    {
        public string RelationshipID { get; private set; }
        public string TableName { get; private set; }

        public ManyOne(string ID, string TableName) : base(ID, TableName)
        {
        }

    }
}
