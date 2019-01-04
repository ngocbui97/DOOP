using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.PropertySQL;

namespace Demo_DOOP_FRAMEWORK
{
    [Table("NGUYENLIEU")]
    public class NGUYENLIEU
    {
        [PrimaryKey("ID",false)]
        [Column("ID", TypeDataRecord.VARCHAR)]
        public string ID { get; set; }

        [Column("NAME", TypeDataRecord.NVARCHAR)]
        public string Name { get; set; }

        [Column("KHO", TypeDataRecord.VARCHAR)]
        [ForeignKey("1", "KHO", "ID")]
        public string IDKHO { get; set; }

        [ManyOne("1", "KHO")]
        public KHO Kho { get; set; }

        [OneOne("2", "GIANGUYENLIEU")]
        [ForeignKey("2", "ID", "ID")]
        public GIANGUYENLIEU Gia { get; set; }
    }
}
