using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DOOP_FRAMEWORK.QuerrySQL
{
   
    /// <summary>
    /// command where in sql
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWhere<T> where T : new()
    {
        IHaving<T> Where(string condition);
        IHaving<T> AllRow();
    }
    /// <summary>
    /// command Group by in sql
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGroupBy<T> where T : new()
    {
        IRunQuery<T> GroupBy(string columnNames);
    }

    /// <summary>
    /// command Having in sql
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHaving<T> where T : new()
    {
        IGroupBy<T> Having(string condition);
        List<T> Run();
    }
}
