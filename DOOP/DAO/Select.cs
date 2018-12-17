using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.Attributes;
using DOOP_FRAMEWORK.DAO;
using DOOP_FRAMEWORK.Common;

namespace DOOP.DAO
{
    public class SelectQuery<T> : Querry, IWhere<T>, IHaving<T>, IGroupBy<T>, IRunQuery<T> where T : new()
    {
        private SelectQuery(SqlConnection cnn, string connectionString) : base(cnn, connectionString)
        {
            Map mapper = new Map();
            queryString += "SELECT";
            foreach (Column column in mapper.GetCol<T>())
                queryString = string.Format("{0} {1},", queryString, column.name);

            queryString = queryString.Substring(0, queryString.Length - 1);

            queryString = string.Format("{0} FROM {1}", queryString, mapper.GetTableName<T>());
        }

        public static IWhere<T> Create(SqlConnection cnn, string queryStringString)
        {
            return new SelectQuery<T>(cnn, queryStringString);
        }

        public IHaving<T> Where(string condition)
        {
            queryString = string.Format("{0} WHERE {1}", queryString, condition);
            return this;
        }

        public IHaving<T> AllRow()
        {
            return this;
        }

        public IGroupBy<T> Having(string condition)
        {
            queryString = string.Format("{0} HAVING {1}", queryString, condition);
            return this;
        }

        public IRunQuery<T> GroupBy(string columnNames)
        {
            queryString = string.Format("{0} GROUP BY {1}", queryString, columnNames);
            return this;
        }

        public List<T> Run()
        {
            return EQuery<T>();
        }
    }
}
