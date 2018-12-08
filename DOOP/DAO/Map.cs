using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.Common;
using DOOP_FRAMEWORK.DAO;

namespace DOOP.DAO
{
    public class Map:aMapping
    {
        
        protected override void MapOneToMany<T>(Connection cnn, DataRow dr, T obj)
        {
            throw new NotImplementedException();
        }


        protected override void MapToOne<T>(Connection cnn, DataRow dr, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
