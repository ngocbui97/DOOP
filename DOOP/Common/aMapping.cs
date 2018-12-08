using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using DOOP_FRAMEWORK.Attributes;
using DOOP_FRAMEWORK.DAO;
namespace DOOP_FRAMEWORK.Common
{
   public abstract class aMapping
    {
        public T MapAndRelationship<T>(Connection cnn, DataRow dr) where T : new()
        {
            T obj = new T();
            var listp = typeof(T).GetProperties();
            for (int i = 0; i < listp.Length; i++)
            {
                var p = listp[i];
                var column = GetFirstOrNull( p.GetCustomAttributes(false), typeof(Column));

                if (column != null)
                {
                    var mapsTo = column as Column;
                    p.SetValue(obj, dr[mapsTo.name]);
                }
            }

            MapOneToMany(cnn, dr, obj);
            MapToOne(cnn, dr, obj);

            return obj;
        }

        //Map không có quan hệ: None Relationship
        public T MapNoneRelationShip<T>(Connection cnn, DataRow dr) where T : new()
        {
            T obj = new T();
            var listp = typeof(T).GetProperties();

            for (int i = 0; i < listp.Length; i++ )
            {
                var p = listp[i];
                var column = GetFirstOrNull( p.GetCustomAttributes(false), typeof(Column));
                if (column != null)
                {
                    var mapsTo = column as Column;
                    p.SetValue(obj, dr[mapsTo.name]);
                }
            }

            return obj;
        }

        protected abstract void MapOneToMany<T>(Connection cnn, DataRow dr, T obj) where T : new();
        protected abstract void MapToOne<T>(Connection cnn, DataRow dr, T obj) where T : new();

        public string GetTableName<T>() where T : new()
        {
            var tableAttributes = typeof(T).GetCustomAttributes(typeof(Table), true);
            var tableAttribute = GetFirstOrNull(tableAttributes, typeof(Table)) as Table;
            if (tableAttribute != null)
                return tableAttribute.name;
            return string.Empty;
        }

        public List<PrimaryKey> GetPrimaryKey<T>() where T : new()
        {
            List<PrimaryKey> listPK = new List<PrimaryKey>();

            var listp = typeof(T).GetProperties();
            for (int i = 0; i < listp.Length; i++)
                {
                    var p = listp[i];
                    var PK = GetFirstOrNull( p.GetCustomAttributes(false), typeof(PrimaryKey));
                    if (PK != null)
                        listPK.Add(PK as PrimaryKey);
                }

            if (listPK.Count > 0)
                return listPK;
            else
                return null;
        }

        public List<ForeignKey> GetForeignKey<T>(string ID) where T : new()
        {
            List<ForeignKey> listFK = new List<ForeignKey>();

            var listp = typeof(T).GetProperties();
            for (int i = 0; i < listp.Length; i++)
                {
                    var p = listp[i];
                    var FK = GetFirstOrNull(p.GetCustomAttributes(false), typeof(ForeignKey));
                    if (FK != null && (FK as ForeignKey).id == ID)
                        listFK.Add(FK as ForeignKey);
                }

            if (listFK.Count > 0)
                return listFK;
            else
                return null;
        }

        public List<Column> GetCol<T>() where T : new()
        {
            List<Column> listCol = new List<Column>();
            var listp = typeof(T).GetProperties();
            for (int i = 0; i < listp.Length; i++)
            {
                var p = listp[i];
                var colMapping = GetFirstOrNull(p.GetCustomAttributes(false), typeof(Column));
                if (colMapping != null)
                {
                    var mapsTo = colMapping as Column;
                    listCol.Add(mapsTo);
                }
            }

            if (listCol.Count > 0)
                return listCol;
            else
                return null;
        }

        public Dictionary<Column, object> GetColValues<T>(T obj)
        {
            Dictionary<Column, object> listColValues = new Dictionary<Column, object>();
            var listp = typeof(T).GetProperties();
            for (int i = 0; i < listp.Length; i++)
            {
                var p = listp[i];
                var colMapping = GetFirstOrNull( p.GetCustomAttributes(false), typeof(Column));
                if (colMapping != null)
                {
                    var mapsTo = colMapping as Column;
                    listColValues.Add(mapsTo, p.GetValue(obj, null));
                }
            }

            if (listColValues.Count > 0)
                return listColValues;
            else
                return null;
        }

        public Column FindCol(string name, Dictionary<Column, object> listColumValues)
        {
            foreach (Column column in listColumValues.Keys)
                if (column.name == name)
                    return column;
            return null;
        }

        public Column FindCol(string name, List<Column> listColumAttributes)
        {
            foreach (Column column in listColumAttributes)
                if (column.name == name)
                    return column;
            return null;
        }

        //listA = list Atribute
        protected object GetFirstOrNull(object[] listA, Type type)
        {

            for (int i = 0; i < listA.Length; i++)
                {
                    var a = listA[i];
                    if (a.GetType() == type)
                        return a;
                }
            return null;
        }

        protected object[] GetAll(object[] listA, Type type)
        {
            object[] objArray = new object[0];
            for (int i = 0; i < listA.Length; i++)
            {
                var a = listA[i];
                if (a.GetType() == type)
                {
                    Array.Resize(ref objArray, objArray.Length + 1);
                    objArray[objArray.Length - 1] = a;
                }
            }
            return objArray;
        }

        public object GetFirst(IEnumerable source)
        {
            IEnumerator iter = source.GetEnumerator();

            if (iter.MoveNext())
            {
                return iter.Current;
            }
            return null;
        }
    }
}
