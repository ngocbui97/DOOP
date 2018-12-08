using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DOOP.DAO;
using DOOP_FRAMEWORK.Attributes;

namespace DOOP_FRAMEWORK.DAO
{
   public class Insert<T> :Querry where T : new()
    {
        public Insert(SqlConnection cnn, string connectionString, T obj) : base(cnn, connectionString)
        {
            Map map = new Map();
            string tableName = map.GetTableName<T>();
            List<PrimaryKey> primaryKeys = map.GetPrimaryKey<T>();
            Dictionary<Column, object> lColValues = map.GetColValues<T>(obj);

            if (lColValues.Count != 0)
            {
                string columnStr = string.Empty;
                string valueStr = string.Empty;

                foreach (Column column in lColValues.Keys)
                {
                    bool isAutoID = false;
                    foreach (PrimaryKey primaryKey in primaryKeys)
                    {
                        if (column.name == primaryKey.name && primaryKey.auto)
                        {
                            isAutoID = true;
                            break;
                        }
                    }

                    if (!isAutoID)
                    {
                        string format = "{0}, ";
                        if (column.type == TypeDataRecord.NCHAR || column.type == TypeDataRecord.NVARCHAR)
                            format = "N'{0}', ";
                        else if (column.type == TypeDataRecord.CHAR || column.type == TypeDataRecord.VARCHAR)
                            format = "'{0}', ";
                        columnStr += string.Format("{0}, ", column.name);
                        valueStr += string.Format(format, lColValues[column]);
                    }
                }
                if (!string.IsNullOrEmpty(columnStr) && !string.IsNullOrEmpty(valueStr))
                {
                    columnStr = columnStr.Substring(0, columnStr.Length - 2);
                    valueStr = valueStr.Substring(0, valueStr.Length - 2);
                    queryString = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columnStr, valueStr);
                }
            }
        }
    }
}
