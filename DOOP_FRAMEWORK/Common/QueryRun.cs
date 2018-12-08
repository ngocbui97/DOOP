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
            List<T> ExecuteQueryWithOutRelationship<T>() where T : new();
            int ExecuteNonQuery();
        }

        public interface RunQuery<T> where T : new()
        {
            List<T> Run();
        }

}
