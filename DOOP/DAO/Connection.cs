using System;
using System.Collections.Generic;
using System.Text;
using DOOP_FRAMEWORK.Common;
using System.Data.SqlClient;

namespace DOOP_FRAMEWORK.DAO
{
   public class Connection:aConnection
    {
        public SqlConnection scn;
        public Connection(string cnnString)
        {
            this.cnnString = cnnString;
            scn = new SqlConnection(cnnString);
        }
        //public override IWhere<T> Select<T>()
        //{
        //    //Phuc implement use class DAO.SeLect
        //}
        //public abstract int Insert<T>(T obj) 
        //{
        //    return 0;
        //}
        //public abstract int Update<T>(T obj) where T : new();
        //public abstract int Delete<T>(T obj) where T : new();
        //public abstract List<T> ExecuteQuery<T>(string query) where T : new();
        //public abstract List<T> ExecuteQueryWithOutRelationship<T>(string query) where T : new();
        //public abstract int ExecuteNonQuery(string query);
        public override void Open() {
            if (this.scn == null) { scn.Open(); }
        }
        public override void Close()
        {
            if (this.scn != null) { scn.Close(); }
        }

        public override void Insert<T>(T obj)
        {
            Insert<T> q = new DAO.Insert<T>(scn, cnnString, obj);
            q.ExecuteNonQuery();
        }

        public override void Update<T>(T obj)
        {
           
        }

        public override void Delete<T>(T obj)
        {
            Delete<T> q = new DAO.Delete<T>(scn, cnnString, obj);
            q.ExecuteNonQuery();
        }

        public override List<T> ExecuteQuery<T>(string query)
        {
            throw new NotImplementedException();
        }

        public override List<T> ExecuteQueryWithOutRelationship<T>(string query)
        {
            throw new NotImplementedException();
        }

        public override int ExecuteNonQuery(string query)
        {
            throw new NotImplementedException();
        }

        public override IWhere<T> Select<T>()
        {
            throw new NotImplementedException();
        }
    }
}
