using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using DOOP_FRAMEWORK.PropertySQL;

namespace DOOP_FRAMEWORK.Public
{
   public abstract class aMapping
    {
        protected abstract void MapOneToMany<T>(aConnection cnn, DataRow dr, T obj) where T : new();
        protected abstract void MapToOne<T>(aConnection cnn, DataRow dr, T obj) where T : new();

        public string GetNameTable<T>() where T : new()
        {
            var tableAttributes = typeof(T).GetCustomAttributes(typeof(Table), true);
            var tableAttribute = GetFirstOrNull(tableAttributes, typeof(Table)) as Table;
            if (tableAttribute != null)
                return tableAttribute.name;
            return string.Empty;
        }

        public List<PrimaryKey> GetPK<T>() where T : new()
        {
            List<PrimaryKey> listPK = new List<PrimaryKey>();
            var listp = typeof(T).GetProperties();
            foreach (var p in listp)
            {
                var PK = GetFirstOrNull(p.GetCustomAttributes(false), typeof(PrimaryKey));
                if (PK != null)
                    listPK.Add(PK as PrimaryKey);
            }
           if (listPK.Count > 0)
                return listPK;
           else return null;
        }

        public List<ForeignKey> GetFK<T>(string ID) where T : new()
        {
            List<ForeignKey> listFK = new List<ForeignKey>();

            var listp = typeof(T).GetProperties();
            for (int i = 0; i < listp.Length; i++)
                {
                    var FK = GetFirstOrNull(listp[i].GetCustomAttributes(false), typeof(ForeignKey));
                    if (FK != null && (FK as ForeignKey).id == ID)
                        listFK.Add(FK as ForeignKey);
                }

            if (listFK.Count > 0)
                return listFK;
            else
                return null;
        }

        public object GetFirst(IEnumerable source)
        {
            IEnumerator ie = source.GetEnumerator();
            if (ie.MoveNext())
            {
                return ie.Current;
            }
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
            var list = typeof(T).GetProperties();
            Dictionary<Column, object> listCol = new Dictionary<Column, object>();
            for (int i = 0; i < list.Length; i++)
            {
                var p = list[i];
                var colMapping = GetFirstOrNull( p.GetCustomAttributes(false), typeof(Column));
                if (colMapping != null)
                {
                    var mapsTo = colMapping as Column;
                    listCol.Add(mapsTo, p.GetValue(obj, null));
                }
            }

            if (listCol.Count > 0)
                return listCol;
            else
                return null;
        }

        public Column FindCol(string name, Dictionary<Column, object> listCol)
        {
            foreach (Column col in listCol.Keys)
                if (col.name == name)
                    return col;
            return null;
        }

        //Get all element with specific type
        protected object[] GetAll(object[] arrs, Type type)
        {
            object[] Arrs = new object[0];
            for (int i = 0; i < arrs.Length; i++)
            {
                var a = arrs[i];
                if (a.GetType() == type)
                {
                    Array.Resize(ref Arrs, Arrs.Length + 1);
                    Arrs[Arrs.Length - 1] = a;
                }
            }
            return Arrs;
        }


        public Column FindCol(string name, List<Column> listCol)
        {
            foreach (Column col in listCol)
                if (col.name == name)
                    return col;
            return null;
        }

        //listA = list Atribute
        protected object GetFirstOrNull(object[] arrs, Type type)
        {

            for (int i = 0; i < arrs.Length; i++)
                {
                if (arrs[i].GetType().Equals(type))
                    return arrs[i] ;
                }
            return null;
        }

        public T MapAndRelationship<T>(aConnection cnn, DataRow dr) where T : new()
        {
            T obj = new T();
            var listp = typeof(T).GetProperties();
            //for (int i = 0; i < listp.Length; i++)
            foreach(var p in listp)
            {
               // var p = listp[i];
                //get value object Column
                var column = GetFirstOrNull(p.GetCustomAttributes(false), typeof(Column));

                if (column != null)
                {
                    // parse to value of Column
                    var mapsTo = column as Column;
                    //set value tuong ung for obj 
                    p.SetValue(obj, dr[mapsTo.name]);
                }
            }

            MapOneToMany(cnn, dr, obj);
            MapToOne(cnn, dr, obj);

            return obj;
        }

        //Map không có quan hệ: None Relationship
        public T MapNoneRelationShip<T>(aConnection cnn, DataRow dr) where T : new()
        {
            T obj = new T();
            var listp = typeof(T).GetProperties();

            for (int i = 0; i < listp.Length; i++)
            {
                var p = listp[i];
                var column = GetFirstOrNull(p.GetCustomAttributes(false), typeof(Column));
                if (column != null)
                {
                    var mapsTo = column as Column;
                    listp[i].SetValue(obj, dr[mapsTo.name]);
                }
            }

            return obj;
        }
       

    }
}
