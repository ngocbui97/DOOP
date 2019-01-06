using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.PropertySQL;

namespace Demo_DOOP_FRAMEWORK
{
    [Table("MONAN")]
    public class MONAN
    {
        [PrimaryKey("ID", false)]
        [Column("ID", TypeDataRecord.VARCHAR)]
        public string ID { get; set; }

        [Column("TENMONAN", TypeDataRecord.NVARCHAR)]
        public string Name { get; set; }

        [Column("NGUYENLIEU", TypeDataRecord.NVARCHAR)]
        public string DSNguyenLieu { get; set; }

        [Column("HINHANH", TypeDataRecord.NVARCHAR)] 
        public string URL { get; set; }

        [OneMany("1", "NGUYENLIEU")]
        public List<NGUYENLIEU> DanhSachNguyenLieu { get; set; }
    }
}
