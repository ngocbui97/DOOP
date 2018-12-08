using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Common
{

        public interface IQuery
        {
            List<T> ExecuteQuery<T>() where T : new();
            List<T> ExecuteQueryNoneRelationShip<T>() where T : new();
            void ExecuteNonQuery();
        }

        public interface IRunQuery<T> where T : new()
        {
            List<T> Run();
        }

}
