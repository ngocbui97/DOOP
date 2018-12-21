using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DOOP.DAO;
using DOOP_FRAMEWORK.PropertySQL;

namespace DOOP_FRAMEWORK.DAO
{
   public class Insert<T> :Querry where T : new()
    {
        /// <summary>
        /// Create querry string Insert
        /// </summary>
        /// <param name="cnn"></param>
        /// <param name="connectionString"></param>
        /// <param name="obj"></param>
        public Insert(SqlConnection cnn, string connectionString, T obj) : base(cnn, connectionString)
        {
            Map map = new Map();
            // list pkeys
            List<PrimaryKey> primaryKeys = map.GetPrimaryKey<T>();
            // list col of obj
            Dictionary<Column, object> lCol = map.GetColValues<T>(obj);
   
            if (lCol.Count != 0)
            {
                string colStr = string.Empty;
                string valStr = string.Empty;

                foreach (Column col in lCol.Keys)
                {
                    bool isAutoID = false;
                    // check if have auto Id
                    foreach (PrimaryKey primaryKey in primaryKeys)
                    {
                        if (col.name == primaryKey.name && primaryKey.auto)
                        {
                            isAutoID = true;
                            break;
                        }
                    }
                    // create format string in parameter for querry
                    if (!isAutoID)
                    {
                        string format = "{0}, ";
                        if (col.type == TypeDataRecord.NCHAR || col.type == TypeDataRecord.NVARCHAR)
                            format = "N'{0}', ";
                        else if (col.type == TypeDataRecord.CHAR || col.type == TypeDataRecord.VARCHAR)
                            format = "'{0}', ";
                        colStr += string.Format("{0}, ", col.name);// col
                        valStr += string.Format(format, lCol[col]);// value
                    }
                }
                if (colStr!=String.Empty && valStr != String.Empty)
                {
                    colStr = colStr.Substring(0, colStr.Length - 2);
                    valStr = valStr.Substring(0, valStr.Length - 2);
                    queryString = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", map.GetTableName<T>(), colStr, valStr);
                }
            }
        }
    }
}
