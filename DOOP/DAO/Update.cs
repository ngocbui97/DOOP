﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.Attributes;
using DOOP_FRAMEWORK.DAO;
using DOOP_FRAMEWORK.Common;

namespace DOOP.DAO
{
    public class Update<T> : Querry where T : new()
    {
        public Update(SqlConnection cnn, string connectionString, T obj) : base(cnn, connectionString)
        {
            Map mapper = new Map();

            string tableName = mapper.GetTableName<T>();
            List<PrimaryKey> primaryKeys = mapper.GetPrimaryKey<T>();
            Dictionary<Column, object> listColumnValues = mapper.GetColValues<T>(obj);

            if (listColumnValues != null && primaryKeys != null)
            {
                string setStr = string.Empty;
                string whereStr = string.Empty;

                foreach (Column column in listColumnValues.Keys)
                {
                    string format = "{0} = {1}, ";
                    if (column.type == TypeDataRecord.NCHAR || column.type == TypeDataRecord.NVARCHAR)
                        format = "{0} = N'{1}', ";
                    else if (column.type == TypeDataRecord.CHAR || column.type == TypeDataRecord.VARCHAR)
                        format = "{0} = '{1}', ";

                    setStr += string.Format(format, column.name, listColumnValues[column]);
                }
                if (!string.IsNullOrEmpty(setStr))
                    setStr = setStr.Substring(0, setStr.Length - 2);

                foreach (PrimaryKey primaryKey in primaryKeys)
                {
                    Column column = mapper.FindCol(primaryKey.name, listColumnValues);
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
                    queryString = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, setStr, whereStr);
                }
            }
        }
    }
}
