using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.Common;
using DOOP_FRAMEWORK.DAO;

namespace DOOP.DAO
{
    public class Querry:IQuery
    {
        protected string cnnString;
        protected SqlCommand cmd;
        protected string queryString;
       

        public Querry(SqlConnection cnn, string cnnString, string queryString)
        {
            cmd = new SqlCommand();
            cmd.Connection = cnn;
            this.cnnString = cnnString;       
            this.queryString = queryString;
        }

        public Querry(SqlConnection cnn, string cnnString)
        {
            cmd = new SqlCommand();
            cmd.Connection = cnn;
            this.cnnString = cnnString;
        }

        public List<T> EQuery<T>() where T : new()
        {
            List<T> res = new List<T>();
            Connection cnn = new Connection(cnnString);
            Map map = new Map();
            cmd.CommandText = this.queryString;
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
                res.Add(map.MapAndRelationship<T>(cnn, dr));
            return res;
        }

        public List<T> EQueryNoneRelationShip<T>() where T : new()
        {
            Connection cnn = new Connection(cnnString);
            cmd.CommandText = queryString;
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            Map map = new Map();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            List<T> res = new List<T>();
            foreach (DataRow dr in dt.Rows)
                res.Add(map.MapNoneRelationShip<T>(cnn, dr));

            return res;
        }

        public int ENoneQuery()
        {
            cmd.CommandText = this.queryString;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }
    }
}
