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
        /// <summary>
        /// create string querry delete
        /// </summary>
        /// <param name="cnn"></param>
        /// <param name="connectionString"></param>
        /// <param name="obj"></param>
        public Delete(SqlConnection cnn, string connectionString, T obj) : base(cnn, connectionString)
        {
            string whereStr=string.Empty ;
            Map map = new Map();
            // get list pkeys
            List<PrimaryKey> PKS = map.GetPrimaryKey<T>();
            // get list col
            Dictionary<Column, object> listCol = map.GetColValues<T>(obj);        
            foreach (PrimaryKey pk in PKS)
            {
                // col of primary key
                Column col = map.FindCol(pk.name, listCol);
                if (col != null)
                {
                    string format = "{0} = {1}, "; // nomal letter
                    if (col.type == TypeDataRecord.NCHAR || col.type == TypeDataRecord.NVARCHAR)
                        format = "{0} = N'{1}', ";// type unicode
                    else if (col.type == TypeDataRecord.CHAR || col.type == TypeDataRecord.VARCHAR)
                        format = "{0} = '{1}', "; // type character
                    whereStr += string.Format(format, pk.name, listCol[col]);
                }
            }
            if (whereStr!=String.Empty)
            {
                whereStr = whereStr.Substring(0, whereStr.Length - 2);//=>that string ", "
                queryString = string.Format("DELETE {0} WHERE {1}", map.GetTableName<T>(), whereStr);
            }
        }
    }
}
