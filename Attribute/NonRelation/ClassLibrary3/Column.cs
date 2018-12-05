using System;

namespace ClassLibrary3
{
    public class Column:Attribute
    {
        private string Name;
        private int datatype;

        public Column(string Name, int datatype)
        {
            this.Name = Name;
            this.datatype = datatype;
        }

        public string name
        {
            get { return this.Name; }
        }
        public int type
        {
            get { return this.type; }
        }
    }
}