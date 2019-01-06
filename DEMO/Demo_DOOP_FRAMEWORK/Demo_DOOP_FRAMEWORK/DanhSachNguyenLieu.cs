using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOOP_FRAMEWORK.Public;
using DOOP_FRAMEWORK.DAO;

namespace Demo_DOOP_FRAMEWORK
{
    public partial class DanhSachNguyenLieu : Form
    {
        List<NGUYENLIEU> DanhSachNL = null;
        aConnection connection = null;
        public string connectionAdd = "Data Source=LEHUULY-PC\\SQLEXPRESS;Initial Catalog=QUANLYNGUYENLIEU;Integrated Security=True";
        public DanhSachNguyenLieu()
        {
            InitializeComponent();
            connection = new Connection(connectionAdd);
        }

        string nguyenlieu = null;

        private void DanhSachNguyenLieu_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DanhSachNL = connection.EQuery<NGUYENLIEU>("SELECT * FROM NGUYENLIEU");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (NGUYENLIEU nguyenlieu in DanhSachNL)
                checkedListBox1.Items.Add(nguyenlieu.Name);
        }

        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string ss in checkedListBox1.CheckedItems)
                listBox1.Items.Add(ss);
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            foreach (string ss in listBox1.Items)
                nguyenlieu = nguyenlieu + ss + ", ";
            nguyenlieu = nguyenlieu.Remove(nguyenlieu.Length - 2, 2);
        }

        public string Sendata
        {
            get
            {
                return this.nguyenlieu;
            }
        }
    }
}
