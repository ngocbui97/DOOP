using System;
using System.Collections.Generic;
using System.Text;
using DOOP_FRAMEWORK.Public;
using System.Data.SqlClient;
using DOOP.DAO;
using DOOP_FRAMEWORK.QuerrySQL;

namespace DOOP_FRAMEWORK.DAO
{
   public class Connection:aConnection
    {
        public SqlConnection scn;
        // create connection
        public Connection(string cnnString)
        {
            this.cnnString = cnnString;
            scn = new SqlConnection(cnnString);
        }
       
        /// <summary>
        /// open connection
        /// </summary>
        public override void Open() {
            if (this.scn == null) { scn.Open(); }
        }

        /// <summary>
        /// close connection
        /// </summary>
        public override void Close()
        {
            if (this.scn != null) { scn.Close(); }
        }

        /// <summary>
        /// method run querry Insert
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public override void Insert<T>(T obj)
        {
            Insert<T> q = new DAO.Insert<T>(scn, cnnString, obj);
            q.ENoneQuery();
        }
        /// <summary>
        /// method run querry update
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override int Update<T>(T obj)
        {
            Update<T> query = new Update<T>(scn, cnnString, obj);
            return query.ENoneQuery();
        }
        /// <summary>
        /// method run querry delete
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public override void Delete<T>(T obj)
        {
            Delete<T> q = new DAO.Delete<T>(scn, cnnString, obj);
            q.ENoneQuery();
        }
        /// <summary>
        /// method run querry excute with relation ship
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public override List<T> EQuery<T>(string query)
        {
            Querry q = new Querry(scn, cnnString, query);
            return q.EQuery<T>();
        }

        /// <summary>
        /// method run querrry without relation ship 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public override List<T> EQueryNoneRelationship<T>(string query)
        {
            Querry q = new Querry(scn, cnnString, query);
            return q.EQueryNoneRelationShip<T>();
        }
        /// <summary>
        /// method excute querry not return data
        /// </summary>
        /// <param name="query"></param>
        public override void ENoneQuery(string query)
        {
            Querry q = new Querry(scn, cnnString, query);
            q.ENoneQuery();
        }
        /// <summary>
        /// method run querry select
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public override IWhere<T> Select<T>()
        {
            return SelectQuery<T>.Create(scn, cnnString);
        }
    }
}
