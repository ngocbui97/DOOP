using System;
using System.Collections.Generic;
using System.Text;
using DOOP_FRAMEWORK.Common;
using System.Data.SqlClient;
using DOOP.DAO;

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
            q.ENoneQuery();
        }

        public override int Update<T>(T obj)
        {
            Update<T> query = new Update<T>(scn, cnnString, obj);
            return query.ENoneQuery();
        }

        public override void Delete<T>(T obj)
        {
            Delete<T> q = new DAO.Delete<T>(scn, cnnString, obj);
            q.ENoneQuery();
        }

        public override List<T> EQuery<T>(string query)
        {
            Querry q = new Querry(scn, cnnString, query);
            return q.EQuery<T>();
        }

        public override List<T> EQueryNoneRelationship<T>(string query)
        {
            Querry q = new Querry(scn, cnnString, query);
            return q.EQueryNoneRelationShip<T>();
        }

        public override void ENoneQuery(string query)
        {
            Querry q = new Querry(scn, cnnString, query);
            q.ENoneQuery();
        }

        public override IWhere<T> Select<T>()
        {
            return SelectQuery<T>.Create(scn, cnnString);
        }
    }
}
