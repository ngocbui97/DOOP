using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOOP_FRAMEWORK.DAO;
using DOOP_FRAMEWORK.Public;

namespace Demo_DOOP_FRAMEWORK
{
    public partial class Form1 : Form
    {
        aConnection connection = null;
        List<NGUYENLIEU> DanhSachNL = null;
        List<KHO> DanhSachKH = null;
        public string connectionAdd = "Data Source=LEHUULY-PC\\SQLEXPRESS;Initial Catalog=QUANLYNGUYENLIEU;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            connection = new Connection(connectionAdd);
            dropsave.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbkeyword.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbkeyword.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DanhSachNL = connection.EQuery<NGUYENLIEU>("SELECT * FROM NGUYENLIEU");
                DanhSachKH = connection.Select<KHO>().AllRow().Run();
                ThemKho(DanhSachKH);
                ThayDoiDanhSachNguyenLieu(DanhSachNL);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                List<NGUYENLIEU> temp = null;
                if (string.IsNullOrEmpty(txtkeyword.Text))
                    DanhSachNL = connection.Select<NGUYENLIEU>().AllRow().Run();
                else
                {
                    if(cbbkeyword.Text.Equals("Mã món ăn"))
                        temp = connection.Select<NGUYENLIEU>().Where("ID LIKE N'%" + txtkeyword.Text + "%'").Run();
                    else if(cbbkeyword.Text.Equals("Tên món ăn"))
                        temp = connection.Select<NGUYENLIEU>().Where("NAME LIKE N'%" + txtkeyword.Text + "%'").Run();
                    DanhSachNL = temp;
                }
                if (temp == null || DanhSachNL.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả");
                else
                    ThayDoiDanhSachNguyenLieu(DanhSachNL);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtname.Text) || dropsave.SelectedIndex <= 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                NGUYENLIEU s = new NGUYENLIEU();
                s.ID = txtid.Text;
                s.Name = txtname.Text;
                s.IDKHO = ((ComboboxItem)dropsave.SelectedItem).Value;

                try
                {
                    connection.Open();
                    connection.Insert(s);
                    connection.Close();
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrEmpty(txtname.Text) || dropsave.SelectedIndex <= 0)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                NGUYENLIEU s = new NGUYENLIEU();
                s.ID = txtid.Text;
                s.Name = txtname.Text;
                s.IDKHO = ((ComboboxItem)dropsave.SelectedItem).Value;

                try
                {
                    connection.Open();
                    connection.Update(s);
                    connection.Close();
                    Form1_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = danhsachnguyenlieu.CurrentCell.RowIndex;

            try
            {
                connection.Open();
                connection.Delete(DanhSachNL[selectedRowIndex]);
                connection.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ThemKho(List<KHO> DanhSachKho)
        {
            dropsave.DisplayMember = "Text";
            dropsave.ValueMember = "Value";

            dropsave.Items.Clear();
            dropsave.Items.Add(new ComboboxItem("-- Chọn --", ""));
            foreach (KHO Kho in DanhSachKH)
            {
                dropsave.Items.Add(new ComboboxItem(Kho.Name, Kho.ID));
            }
            dropsave.SelectedIndex = 0;
        }

        private void ThayDoiDanhSachNguyenLieu(List<NGUYENLIEU> DSNguyenLieu)
        {
            danhsachnguyenlieu.Rows.Clear();
            foreach (NGUYENLIEU nguyenlieu in DSNguyenLieu)
            {
                double gia = 0;
                if (nguyenlieu.Gia != null)
                    gia = nguyenlieu.Gia.GiaNL;

                danhsachnguyenlieu.Rows.Add(nguyenlieu.ID, nguyenlieu.Name, gia, nguyenlieu.Kho.Name);
            }
        }

        private void danhsachnguyenlieu_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = danhsachnguyenlieu.CurrentCell.RowIndex;
            txtid.Text = DanhSachNL[selectedRowIndex].ID;
            txtname.Text = DanhSachNL[selectedRowIndex].Name;
            for (int i = 0; i < dropsave.Items.Count; i++)
                if (((ComboboxItem)dropsave.Items[i]).Value == DanhSachNL[selectedRowIndex].Kho.ID)
                    dropsave.SelectedIndex = i;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DanhSachNL = connection.EQuery<NGUYENLIEU>("SELECT * FROM NGUYENLIEU");
                DanhSachKH = connection.Select<KHO>().AllRow().Run();
                ThayDoiDanhSachNguyenLieu(DanhSachNL);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ComboboxItem(string t, string v)
        {
            Text = t;
            Value = v;
        }
    }
}
