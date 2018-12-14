using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_FRAMEWORK.Common
{
   public abstract class aConnection
    {
        protected string cnnString { get; set; }
        public abstract IWhere<T> Select<T>() where T : new();
        public abstract void Insert<T>(T obj) where T : new();
        public abstract void Update<T>(T obj) where T : new();
        public abstract void Delete<T>(T obj) where T : new();
        public abstract List<T> EQuery<T>(string query) where T : new();
        public abstract List<T> EQueryNoneRelationship<T>(string query) where T : new();
        public abstract void ENoneQuery(string query);
        public abstract void Open();
        public abstract void Close();
    }
}
