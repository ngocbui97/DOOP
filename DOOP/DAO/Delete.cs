using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DOOP.DAO;
using DOOP_FRAMEWORK.PropertySQL;

namespace DOOP_FRAMEWORK.DAO
{
    public class Delete<T> :Querry where T: new()
    {
        public Delete(SqlConnection cnn, string connectionString, T obj) : base(cnn, connectionString)
        {
            Map map = new Map();
            string tbName = map.GetTableName<T>();
            List<PrimaryKey> primaryKeys = map.GetPrimaryKey<T>();
            Dictionary<Column, object> listCol = map.GetColValues<T>(obj);
            string whereStr = string.Empty;
            foreach (PrimaryKey primaryKey in primaryKeys)
            {
                Column col = map.FindCol(primaryKey.name, listCol);
                if (col != null)
                {
                    string format = "{0} = {1}, ";
                    if (col.type == TypeDataRecord.NCHAR || col.type == TypeDataRecord.NVARCHAR)
                        format = "{0} = N'{1}', ";
                    else if (col.type == TypeDataRecord.CHAR || col.type == TypeDataRecord.VARCHAR)
                        format = "{0} = '{1}', ";

                    whereStr += string.Format(format, primaryKey.name, listCol[col]);
                }
            }
            if (!string.IsNullOrEmpty(whereStr))
            {
                whereStr = whereStr.Substring(0, whereStr.Length - 2);
                queryString = string.Format("DELETE {0} WHERE {1}", tbName, whereStr);
            }
        }
    }
}
