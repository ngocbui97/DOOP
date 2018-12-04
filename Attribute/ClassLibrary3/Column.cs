using System;

namespace ClassLibrary3
{
    public class Column:Attribute
    {
        public string Name { get; private set; }
        public int datatype { get ; private set; }

        public Column(string Name, int datatype)
        {
            this.Name = Name;
            this.datatype = datatype;
        }
    }
}