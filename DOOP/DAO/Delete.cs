using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DOOP.DAO;
using DOOP_FRAMEWORK.Attributes;

namespace DOOP_FRAMEWORK.DAO
{
    public class Delete<T> :Querry where T: new()
    {
        public Delete(SqlConnection cnn, string connectionString, T obj) : base(cnn, connectionString)
        {
            Map map = new Map();
            string tbName = map.GetTableName<T>();
            List<PrimaryKey> primaryKeys = map.GetPrimaryKey<T>();
            Dictionary<Column, object> listColumnValues = map.GetColValues<T>(obj);

            string whereStr = string.Empty;
            foreach (PrimaryKey primaryKey in primaryKeys)
            {
                Column column = map.FindCol(primaryKey.name, listColumnValues);
                if (column != null)
                {
                    string format = "{0} = {1}, ";
                    if (column.type == TypeDataRecord.NCHAR || column.type == TypeDataRecord.NVARCHAR)
                        format = "{0} = N'{1}', ";
                    else if (column.type == TypeDataRecord.CHAR || column.type == TypeDataRecord.VARCHAR)
                        format = "{0} = '{1}', ";

                    whereStr += string.Format(format, primaryKey.name, listColumnValues[column]);
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
