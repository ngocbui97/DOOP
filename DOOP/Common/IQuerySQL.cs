using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DOOP_FRAMEWORK.Common
{
   
    public interface IWhere<T> where T : new()
    {
        IHaving<T> Where(string condition);
        IHaving<T> AllRow();
    }

    public interface IGroupBy<T> where T : new()
    {
        IRunQuery<T> GroupBy(string columnNames);
    }

    public interface IHaving<T> where T : new()
    {
        IGroupBy<T> Having(string condition);
        List<T> Run();
    }
}
