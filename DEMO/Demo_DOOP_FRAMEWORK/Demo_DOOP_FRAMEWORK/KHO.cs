using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOOP_FRAMEWORK.PropertySQL;

namespace Demo_DOOP_FRAMEWORK
{
    [Table("KHO")]
    public class KHO
    {
        [PrimaryKey("ID", false)]
        [Column("ID", TypeDataRecord.VARCHAR)]
        public string ID { get; set; }

        [Column("NAME", TypeDataRecord.NVARCHAR)]
        public string Name { get; set; }

        [OneMany("1", "NGUYENLIEU")]
        public List<NGUYENLIEU> DanhSachNguyenLieu { get; set; }
    }
}
