using System;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.PropertySQL;
using DOOP_FRAMEWORK.QuerrySQL;
using DOOP_FRAMEWORK.DAO;
using DOOP_FRAMEWORK.Public;

namespace DOOP.DAO
{
    public class Map:aMapping
    {

        /// <summary>
        /// set data to MapOneToMany property in obj
        /// </summary>
        /// <param name="cnn"></param>
        /// <param name="connectionString"></param>
        /// <param name="obj"></param>
        protected override void MapOneToMany<T>(aConnection cnn, DataRow dr, T obj)
        {
            //list property of object 
            var listP = typeof(T).GetProperties();

            for (int i = 0; i < listP.Length; i++)
            {
                var attributes = listP[i].GetCustomAttributes(false);
                // get attribute if this is OneToMany
                var oneToManyAttributes = GetAll(attributes, typeof(OneMany));//get all attribute one to many

                //set property
                if (oneToManyAttributes != null && oneToManyAttributes.Length != 0)
                {
                    foreach (OneMany oneToManyAttribute in oneToManyAttributes)
                    {
                        Type type = listP[i].PropertyType;
                        if (type.IsGenericType)
                        {
                            Type itemType = type.GetGenericArguments()[0];
                            Map mapper = new Map();

                            //get table name
                            MethodInfo getnameTableMethod = mapper.GetType().GetMethod("GetNameTable")
                               .MakeGenericMethod(new Type[] { itemType });
                            string nameTable = getnameTableMethod.Invoke(mapper, null) as string;

                            //get foreignKey
                            MethodInfo getForeignKeyAttributeMethod = mapper.GetType().GetMethod("GetFK")
                               .MakeGenericMethod(new Type[] { itemType });
                            List<ForeignKey> foreignKeyAttributes = getForeignKeyAttributeMethod.Invoke(mapper, new object[] { oneToManyAttribute.relationId }) as List<ForeignKey>;

                            //get list column
                            MethodInfo getColumnAttributeMethod = mapper.GetType().GetMethod("GetCol")
                                .MakeGenericMethod(typeof(T));
                            List<Column> columnAttributes = getColumnAttributeMethod.Invoke(mapper, null) as List<Column>;

                            //set where string foreign key
                            string whereStr = string.Empty;
                            if (foreignKeyAttributes != null)
                            {
                                foreach (ForeignKey foreignKeyAttribute in foreignKeyAttributes)
                                {
                                    Column column = FindCol(foreignKeyAttribute.references, columnAttributes);
                                    if (column != null)
                                    {
                                        string format = "{0} = {1}, ";
                                        if (column.type == TypeDataRecord.NCHAR || column.type == TypeDataRecord.NVARCHAR)
                                            format = "{0} = N'{1}', ";
                                        else if (column.type == TypeDataRecord.CHAR || column.type == TypeDataRecord.VARCHAR)
                                            format = "{0} = '{1}', ";

                                        whereStr += string.Format(format, foreignKeyAttribute.name, dr[foreignKeyAttribute.references]);
                                    }
                                }
                            }
                            //Execute query if where have relationship
                            if (!string.IsNullOrEmpty(whereStr))
                            {
                                whereStr = whereStr.Substring(0, whereStr.Length - 2);
                                string query = string.Format("SELECT * FROM {0} WHERE {1}", nameTable, whereStr);

                                cnn.Open();
                                MethodInfo method = cnn.GetType().GetMethod("EQueryNoneRelationship")
                                .MakeGenericMethod(new Type[] { itemType });
                                listP[i].SetValue(obj, method.Invoke(cnn, new object[] { query }));  //return data to property
                                cnn.Close();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// set data to OneToOne and ManyToOne property in obj
        /// </summary>
        /// <param name="cnn"></param>
        /// <param name="connectionString"></param>
        /// <param name="obj"></param>
        protected override void MapToOne<T>(aConnection cnn, DataRow dr, T obj)
        {
            // get list property
            var listP = typeof(T).GetProperties();

            foreach (var p in listP)
            {
                Type type = p.PropertyType;
                var attributes = p.GetCustomAttributes(false);

                //get all object OneOne and ManyOne
                var arr1 = GetAll(attributes, typeof(OneOne));
                var arr2 = GetAll(attributes, typeof(ManyOne));

                var toOneAttributes = new object[arr1.Length + arr2.Length];
                if (toOneAttributes.Length > 0)
                {
                    arr1.CopyTo(toOneAttributes, 0);
                    arr2.CopyTo(toOneAttributes, arr1.Length);
                }

                //set property
                if (toOneAttributes != null && toOneAttributes.Length != 0)
                {
                    foreach (var attribute in toOneAttributes)
                    {
                        string whereStr = string.Empty;
                       
                        string relationID = string.Empty;
                        string nameTable = string.Empty;
                        Map mapper = new Map();

                        if (attribute.GetType() == typeof(OneOne))          //get table name
                        {
                            relationID = (attribute as OneOne).relationId;
                            nameTable = (attribute as OneOne).nameTableRelation;
                        }
                        else
                        {
                            relationID = (attribute as ManyOne).relationId;
                            nameTable = (attribute as ManyOne).nameTableRelation;
                        }
                        //get list foreign key
                        MethodInfo getForeignKeyAttributeMethod = mapper.GetType().GetMethod("GetFK")
                            .MakeGenericMethod(typeof(T));
                        List<ForeignKey> foreignKeyAttributes = getForeignKeyAttributeMethod.Invoke(mapper, new object[] { relationID }) as List<ForeignKey>;
                        
                        //get list column
                        MethodInfo getColumnAttributeMethod = mapper.GetType().GetMethod("GetCol")
                            .MakeGenericMethod(new Type[] { type });
                        List<Column> columnAttributes = getColumnAttributeMethod.Invoke(mapper, null) as List<Column>;

                        //set where string to query
                        if (foreignKeyAttributes != null)
                        {
                            foreach (ForeignKey foreignKeyAttribute in foreignKeyAttributes)
                            {
                                Column column = FindCol(foreignKeyAttribute.references, columnAttributes);
                                if (column != null)
                                {
                                    string format = "{0} = {1}, ";
                                    if (column.type == TypeDataRecord.NCHAR || column.type == TypeDataRecord.NVARCHAR)
                                        format = "{0} = N'{1}', ";
                                    else if (column.type == TypeDataRecord.CHAR || column.type == TypeDataRecord.VARCHAR)
                                        format = "{0} = '{1}', ";

                                    whereStr += string.Format(format, foreignKeyAttribute.references, dr[foreignKeyAttribute.name]);
                                }
                            }
                        }

                        //Execute query if have relationship
                        if (!string.IsNullOrEmpty(whereStr))
                        {
                            whereStr = whereStr.Substring(0, whereStr.Length - 2);
                            string query = string.Format("SELECT * FROM {0} WHERE {1}", nameTable, whereStr);

                            cnn.Open();
                            MethodInfo method = cnn.GetType().GetMethod("EQueryNoneRelationship")
                            .MakeGenericMethod(new Type[] { type });
                            var ienumerable = (System.Collections.IEnumerable)method.Invoke(cnn, new object[] { query });
                            cnn.Close();

                            MethodInfo method2 = mapper.GetType().GetMethod("GetFirst");
                            var firstElement = method2.Invoke(mapper, new object[] { ienumerable });

                            p.SetValue(obj, firstElement);       //return data to property
                        }
                    }
                }
            }
        }
    }
}
