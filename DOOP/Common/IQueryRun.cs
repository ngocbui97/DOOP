using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Common
{

        public interface IQuery
        {
            List<T> EQuery<T>() where T : new();
            List<T> EQueryNoneRelationShip<T>() where T : new();
            int ENoneQuery();
        }

        public interface IRunQuery<T> where T : new()
        {
            List<T> Run();
        }

}
