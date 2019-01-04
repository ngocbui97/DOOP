using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.PropertySQL;

namespace Demo_DOOP_FRAMEWORK
{
    [Table("GIANGUYENLIEU")]
    public class GIANGUYENLIEU
    {
        [PrimaryKey("ID", false)]
        [Column("ID", TypeDataRecord.VARCHAR)]
        public string ID { get; set; }

        [Column("GIA", TypeDataRecord.FLOAT)]
        public double GiaNL { get; set; }
    }
}
