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

        protected override void MapOneToMany<T>(aConnection cnn, DataRow dr, T obj)
        {
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);

                var oneToManyAttributes = GetAll(attributes, typeof(OneMany));
                if (oneToManyAttributes != null && oneToManyAttributes.Length != 0)
                {
                    foreach (OneMany oneToManyAttribute in oneToManyAttributes)
                    {
                        Type type = property.PropertyType;
                        if (type.IsGenericType)
                        {
                            Type itemType = type.GetGenericArguments()[0];
                            Map mapper = new Map();

                            MethodInfo getTableNameMethod = mapper.GetType().GetMethod("GetTableName")
                               .MakeGenericMethod(new Type[] { itemType });
                            string tableName = getTableNameMethod.Invoke(mapper, null) as string;

                            MethodInfo getForeignKeyAttributeMethod = mapper.GetType().GetMethod("GetForeignKeys")
                                .MakeGenericMethod(new Type[] { itemType });
                            List<ForeignKey> foreignKeyAttributes = getForeignKeyAttributeMethod.Invoke(mapper, new object[] { oneToManyAttribute.RelationshipID }) as List<ForeignKey>;

                            MethodInfo getColumnAttributeMethod = mapper.GetType().GetMethod("GetColumns")
                                .MakeGenericMethod(typeof(T));
                            List<Column> columnAttributes = getColumnAttributeMethod.Invoke(mapper, null) as List<Column>;

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
                            if (!string.IsNullOrEmpty(whereStr))
                            {
                                whereStr = whereStr.Substring(0, whereStr.Length - 2);
                                string query = string.Format("SELECT * FROM {0} WHERE {1}", tableName, whereStr);

                                cnn.Open();
                                MethodInfo method = cnn.GetType().GetMethod("ExecuteQueryWithOutRelationship")
                                .MakeGenericMethod(new Type[] { itemType });
                                property.SetValue(obj, method.Invoke(cnn, new object[] { query }));
                                cnn.Close();
                            }
                        }
                    }
                }
            }
        }


        protected override void MapToOne<T>(aConnection cnn, DataRow dr, T obj)
        {
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                Type type = property.PropertyType;
                var attributes = property.GetCustomAttributes(false);

                var arr1 = GetAll(attributes, typeof(OneOne));
                var arr2 = GetAll(attributes, typeof(ManyOne));

                var toOneAttributes = new object[arr1.Length + arr2.Length];
                if (toOneAttributes.Length > 0)
                {
                    arr1.CopyTo(toOneAttributes, 0);
                    arr2.CopyTo(toOneAttributes, arr1.Length);
                }

                if (toOneAttributes != null && toOneAttributes.Length != 0)
                {
                    foreach (var attribute in toOneAttributes)
                    {
                        Map mapper = new Map();
                        string tableName = string.Empty;
                        string whereStr = string.Empty;
                        string relationshipID = string.Empty;

                        if (attribute.GetType() == typeof(OneOne))
                        {
                            relationshipID = (attribute as OneOne).RelationshipID;
                            tableName = (attribute as OneOne).TableName;
                        }
                        else
                        {
                            relationshipID = (attribute as ManyOne).RelationshipID;
                            tableName = (attribute as ManyOne).TableName;
                        }

                        MethodInfo getForeignKeyAttributeMethod = mapper.GetType().GetMethod("GetForeignKeys")
                            .MakeGenericMethod(typeof(T));
                        List<ForeignKey> foreignKeyAttributes = getForeignKeyAttributeMethod.Invoke(mapper, new object[] { relationshipID }) as List<ForeignKey>;

                        MethodInfo getColumnAttributeMethod = mapper.GetType().GetMethod("GetColumns")
                            .MakeGenericMethod(new Type[] { type });

                        List<Column> columnAttributes = getColumnAttributeMethod.Invoke(mapper, null) as List<Column>;

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
                        if (!string.IsNullOrEmpty(whereStr))
                        {
                            whereStr = whereStr.Substring(0, whereStr.Length - 2);
                            string query = string.Format("SELECT * FROM {0} WHERE {1}", tableName, whereStr);

                            cnn.Open();
                            MethodInfo method = cnn.GetType().GetMethod("ExecuteQueryWithOutRelationship")
                            .MakeGenericMethod(new Type[] { type });
                            var ienumerable = (System.Collections.IEnumerable)method.Invoke(cnn, new object[] { query });
                            cnn.Close();

                            MethodInfo method2 = mapper.GetType().GetMethod("GetFirst");
                            var firstElement = method2.Invoke(mapper, new object[] { ienumerable });

                            property.SetValue(obj, firstElement);
                        }
                    }
                }
            }
        }
    }
}
