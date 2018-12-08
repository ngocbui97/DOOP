using System;

namespace DOOP_FRAMEWORK.Attributes
{
    public class Column:Attribute
    {

        private string Name;
        private int dataType;

        public Column(string Name, int datatype)
        {
            this.Name = Name;
            this.dataType = datatype;
        }

        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int type
        {
            get { return this.type; }
            set { this.dataType = value; }
        }
    }
}