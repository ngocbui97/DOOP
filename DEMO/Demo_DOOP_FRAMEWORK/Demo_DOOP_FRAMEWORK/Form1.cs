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
        List<MONAN> DanhSachMA = null;
        public string connectionAdd = "Data Source=LEHUULY-PC\\SQLEXPRESS;Initial Catalog=QUANLYNGUYENLIEU;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            connection = new Connection(connectionAdd);
            dropsave.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbkeyword.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbkeyword.SelectedIndex = 0;
            cbbkeywordfood.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbkeywordfood.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DanhSachNL = connection.EQuery<NGUYENLIEU>("SELECT * FROM NGUYENLIEU");
                DanhSachKH = connection.Select<KHO>().AllRow().Run();
                DanhSachMA = connection.EQuery<MONAN>("SELECT * FROM MONAN");
                ThemKho(DanhSachKH);
                ThayDoiDanhSachNguyenLieu(DanhSachNL);
                ThayDoiDanhSachMonAn(DanhSachMA);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
         
        private void ThayDoiDanhSachMonAn(List<MONAN> DSMonAn)
        {
            danhsachmonan.Rows.Clear();
            foreach (MONAN monan in DSMonAn)
                danhsachmonan.Rows.Add(monan.ID, monan.Name, monan.DSNguyenLieu, monan.URL);
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

        private void btnfind_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                List<NGUYENLIEU> temp = null;
                if (string.IsNullOrEmpty(txtkeyword.Text))
                    DanhSachNL = connection.Select<NGUYENLIEU>().AllRow().Run();
                else
                {
                    if (cbbkeyword.Text.Equals("Mã nguyên liệu"))
                        temp = connection.Select<NGUYENLIEU>().Where("ID LIKE N'%" + txtkeyword.Text + "%'").Run();
                    else if (cbbkeyword.Text.Equals("Tên nguyên liệu"))
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

        private void btnadd_Click_1(object sender, EventArgs e)
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

        private void btnupdate_Click_1(object sender, EventArgs e)
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

        private void btndelete_Click_1(object sender, EventArgs e)
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

        private void btnlist_Click_1(object sender, EventArgs e)
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
        string duongdan = null;
        private void btngetdialog_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            duongdan = openFileDialog1.FileName;
            pictureBox.Image = Image.FromFile(duongdan);
            
        }

        private void btnaddfood_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtidfood.Text) || string.IsNullOrEmpty(txtnamefood.Text) || string.IsNullOrEmpty(txtnguyenlieu.Text)) 
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                MONAN s = new MONAN();
                s.ID = txtidfood.Text;
                s.Name = txtnamefood.Text;
                s.DSNguyenLieu = txtnguyenlieu.Text;
                s.URL = duongdan;
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

        private void btnupdatefood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidfood.Text) || string.IsNullOrEmpty(txtnamefood.Text) || string.IsNullOrEmpty(txtnguyenlieu.Text))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            else
            {
                MONAN s = new MONAN();
                s.ID = txtidfood.Text;
                s.Name = txtnamefood.Text;
                s.DSNguyenLieu = txtnguyenlieu.Text;
                s.URL = duongdan;

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

        private void btndeletefood_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = danhsachmonan.CurrentCell.RowIndex;

            try
            {
                connection.Open();
                connection.Delete(DanhSachMA[selectedRowIndex]);
                connection.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnlistfood_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DanhSachMA = connection.EQuery<MONAN>("SELECT * FROM MONAN");
                ThayDoiDanhSachMonAn(DanhSachMA);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnfindfood_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                List<MONAN> temp = null;
                if (string.IsNullOrEmpty(txtkeywordfood.Text))
                    DanhSachNL = connection.Select<NGUYENLIEU>().AllRow().Run();
                else
                {
                    if (cbbkeywordfood.Text.Equals("Mã món ăn"))
                        temp = connection.Select<MONAN>().Where("ID LIKE N'%" + txtkeywordfood.Text + "%'").Run();
                    else if (cbbkeywordfood.Text.Equals("Tên món ăn"))
                        temp = connection.Select<MONAN>().Where("TENMONAN LIKE N'%" + txtkeywordfood.Text + "%'").Run();
                    DanhSachMA = temp;
                }
                if (temp == null || DanhSachMA.Count == 0)
                    MessageBox.Show("Không tìm thấy kết quả");
                else
                    ThayDoiDanhSachMonAn(DanhSachMA);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void danhsachmonan_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = danhsachmonan.CurrentCell.RowIndex;
            txtidfood.Text = DanhSachMA[selectedRowIndex].ID;
            txtnamefood.Text = DanhSachMA[selectedRowIndex].Name;
            txtnguyenlieu.Text = DanhSachMA[selectedRowIndex].DSNguyenLieu;
            pictureBox.Image = Image.FromFile(DanhSachMA[selectedRowIndex].URL);
        }

        private void btngetlist_Click(object sender, EventArgs e)
        {
            using (DanhSachNguyenLieu ds = new DanhSachNguyenLieu())
            {
                if (ds.ShowDialog() == DialogResult.OK)
                    txtnguyenlieu.Text = ds.Sendata;
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
