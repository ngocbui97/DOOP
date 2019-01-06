namespace Demo_DOOP_FRAMEWORK
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbkeyword = new System.Windows.Forms.ComboBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.danhsachnguyenlieu = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dropsave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btngetdialog = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btngetlist = new System.Windows.Forms.Button();
            this.txtnguyenlieu = new System.Windows.Forms.TextBox();
            this.cbbkeywordfood = new System.Windows.Forms.ComboBox();
            this.btnlistfood = new System.Windows.Forms.Button();
            this.txtkeywordfood = new System.Windows.Forms.TextBox();
            this.txtnamefood = new System.Windows.Forms.TextBox();
            this.txtidfood = new System.Windows.Forms.TextBox();
            this.btnfindfood = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btndeletefood = new System.Windows.Forms.Button();
            this.btnupdatefood = new System.Windows.Forms.Button();
            this.btnaddfood = new System.Windows.Forms.Button();
            this.danhsachmonan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnguyenlieu)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachmonan)).BeginInit();
            this.tabcontrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbbkeyword);
            this.tabPage2.Controls.Add(this.btnlist);
            this.tabPage2.Controls.Add(this.txtkeyword);
            this.tabPage2.Controls.Add(this.txtname);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.btnfind);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btndelete);
            this.tabPage2.Controls.Add(this.btnupdate);
            this.tabPage2.Controls.Add(this.btnadd);
            this.tabPage2.Controls.Add(this.danhsachnguyenlieu);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dropsave);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý nguyên liệu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbbkeyword
            // 
            this.cbbkeyword.FormattingEnabled = true;
            this.cbbkeyword.Items.AddRange(new object[] {
            "Mã nguyên liệu",
            "Tên nguyên liệu"});
            this.cbbkeyword.Location = new System.Drawing.Point(146, 53);
            this.cbbkeyword.Name = "cbbkeyword";
            this.cbbkeyword.Size = new System.Drawing.Size(147, 21);
            this.cbbkeyword.TabIndex = 31;
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlist.Location = new System.Drawing.Point(317, 182);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(204, 63);
            this.btnlist.TabIndex = 30;
            this.btnlist.Text = "Danh sách";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click_1);
            // 
            // txtkeyword
            // 
            this.txtkeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkeyword.Location = new System.Drawing.Point(317, 54);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(117, 22);
            this.txtkeyword.TabIndex = 29;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(146, 119);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(147, 22);
            this.txtname.TabIndex = 18;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(146, 86);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(147, 22);
            this.txtid.TabIndex = 17;
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(440, 53);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(81, 23);
            this.btnfind.TabIndex = 28;
            this.btnfind.Text = "tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Thêm nguyên liệu";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(458, 84);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(63, 92);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(387, 84);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(65, 92);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(317, 84);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(64, 92);
            this.btnadd.TabIndex = 24;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // danhsachnguyenlieu
            // 
            this.danhsachnguyenlieu.AllowUserToAddRows = false;
            this.danhsachnguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachnguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colname,
            this.colcost,
            this.colsave});
            this.danhsachnguyenlieu.Location = new System.Drawing.Point(42, 251);
            this.danhsachnguyenlieu.Name = "danhsachnguyenlieu";
            this.danhsachnguyenlieu.Size = new System.Drawing.Size(484, 209);
            this.danhsachnguyenlieu.TabIndex = 23;
            this.danhsachnguyenlieu.SelectionChanged += new System.EventHandler(this.danhsachnguyenlieu_SelectionChanged);
            // 
            // colid
            // 
            this.colid.HeaderText = "Mã nguyên liệu";
            this.colid.Name = "colid";
            this.colid.Width = 120;
            // 
            // colname
            // 
            this.colname.HeaderText = "Tên nguyên liệu";
            this.colname.Name = "colname";
            this.colname.Width = 110;
            // 
            // colcost
            // 
            this.colcost.HeaderText = "Giá nguyên liệu";
            this.colcost.Name = "colcost";
            this.colcost.Width = 110;
            // 
            // colsave
            // 
            this.colsave.HeaderText = "Nơi lưu trữ";
            this.colsave.Name = "colsave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kho lưu trữ:";
            // 
            // dropsave
            // 
            this.dropsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropsave.FormattingEnabled = true;
            this.dropsave.Location = new System.Drawing.Point(146, 154);
            this.dropsave.Name = "dropsave";
            this.dropsave.Size = new System.Drawing.Size(147, 24);
            this.dropsave.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên nguyên liệu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btngetdialog);
            this.tab1.Controls.Add(this.label9);
            this.tab1.Controls.Add(this.pictureBox);
            this.tab1.Controls.Add(this.btngetlist);
            this.tab1.Controls.Add(this.txtnguyenlieu);
            this.tab1.Controls.Add(this.cbbkeywordfood);
            this.tab1.Controls.Add(this.btnlistfood);
            this.tab1.Controls.Add(this.txtkeywordfood);
            this.tab1.Controls.Add(this.txtnamefood);
            this.tab1.Controls.Add(this.txtidfood);
            this.tab1.Controls.Add(this.btnfindfood);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.btndeletefood);
            this.tab1.Controls.Add(this.btnupdatefood);
            this.tab1.Controls.Add(this.btnaddfood);
            this.tab1.Controls.Add(this.danhsachmonan);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.label7);
            this.tab1.Controls.Add(this.label8);
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(564, 466);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Quản lý món ăn";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btngetdialog
            // 
            this.btngetdialog.Location = new System.Drawing.Point(25, 177);
            this.btngetdialog.Name = "btngetdialog";
            this.btngetdialog.Size = new System.Drawing.Size(95, 124);
            this.btngetdialog.TabIndex = 51;
            this.btngetdialog.Text = "Browser";
            this.btngetdialog.UseVisualStyleBackColor = true;
            this.btngetdialog.Click += new System.EventHandler(this.btngetdialog_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Hình ảnh:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Demo_DOOP_FRAMEWORK.Properties.Resources.fooddy;
            this.pictureBox.Location = new System.Drawing.Point(126, 157);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(199, 144);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 49;
            this.pictureBox.TabStop = false;
            // 
            // btngetlist
            // 
            this.btngetlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngetlist.Location = new System.Drawing.Point(331, 68);
            this.btngetlist.Name = "btngetlist";
            this.btngetlist.Size = new System.Drawing.Size(204, 66);
            this.btngetlist.TabIndex = 48;
            this.btngetlist.Text = "Danh sách nguyên liệu";
            this.btngetlist.UseVisualStyleBackColor = true;
            this.btngetlist.Click += new System.EventHandler(this.btngetlist_Click);
            // 
            // txtnguyenlieu
            // 
            this.txtnguyenlieu.Location = new System.Drawing.Point(126, 129);
            this.txtnguyenlieu.Name = "txtnguyenlieu";
            this.txtnguyenlieu.Size = new System.Drawing.Size(199, 22);
            this.txtnguyenlieu.TabIndex = 47;
            // 
            // cbbkeywordfood
            // 
            this.cbbkeywordfood.FormattingEnabled = true;
            this.cbbkeywordfood.Items.AddRange(new object[] {
            "Mã món ăn",
            "Tên món ăn"});
            this.cbbkeywordfood.Location = new System.Drawing.Point(126, 41);
            this.cbbkeywordfood.Name = "cbbkeywordfood";
            this.cbbkeywordfood.Size = new System.Drawing.Size(199, 24);
            this.cbbkeywordfood.TabIndex = 46;
            // 
            // btnlistfood
            // 
            this.btnlistfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlistfood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlistfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistfood.Location = new System.Drawing.Point(331, 238);
            this.btnlistfood.Name = "btnlistfood";
            this.btnlistfood.Size = new System.Drawing.Size(204, 63);
            this.btnlistfood.TabIndex = 45;
            this.btnlistfood.Text = "Danh sách";
            this.btnlistfood.UseVisualStyleBackColor = false;
            this.btnlistfood.Click += new System.EventHandler(this.btnlistfood_Click);
            // 
            // txtkeywordfood
            // 
            this.txtkeywordfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkeywordfood.Location = new System.Drawing.Point(331, 41);
            this.txtkeywordfood.Name = "txtkeywordfood";
            this.txtkeywordfood.Size = new System.Drawing.Size(117, 22);
            this.txtkeywordfood.TabIndex = 44;
            // 
            // txtnamefood
            // 
            this.txtnamefood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamefood.Location = new System.Drawing.Point(126, 100);
            this.txtnamefood.Name = "txtnamefood";
            this.txtnamefood.Size = new System.Drawing.Size(199, 22);
            this.txtnamefood.TabIndex = 33;
            // 
            // txtidfood
            // 
            this.txtidfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidfood.Location = new System.Drawing.Point(126, 72);
            this.txtidfood.Name = "txtidfood";
            this.txtidfood.Size = new System.Drawing.Size(199, 22);
            this.txtidfood.TabIndex = 32;
            // 
            // btnfindfood
            // 
            this.btnfindfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfindfood.Location = new System.Drawing.Point(454, 41);
            this.btnfindfood.Name = "btnfindfood";
            this.btnfindfood.Size = new System.Drawing.Size(81, 23);
            this.btnfindfood.TabIndex = 43;
            this.btnfindfood.Text = "tìm kiếm";
            this.btnfindfood.UseVisualStyleBackColor = true;
            this.btnfindfood.Click += new System.EventHandler(this.btnfindfood_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "Thêm món ăn";
            // 
            // btndeletefood
            // 
            this.btndeletefood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btndeletefood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeletefood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletefood.Location = new System.Drawing.Point(472, 140);
            this.btndeletefood.Name = "btndeletefood";
            this.btndeletefood.Size = new System.Drawing.Size(63, 92);
            this.btndeletefood.TabIndex = 41;
            this.btndeletefood.Text = "Xóa";
            this.btndeletefood.UseVisualStyleBackColor = false;
            this.btndeletefood.Click += new System.EventHandler(this.btndeletefood_Click);
            // 
            // btnupdatefood
            // 
            this.btnupdatefood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnupdatefood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdatefood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatefood.Location = new System.Drawing.Point(401, 140);
            this.btnupdatefood.Name = "btnupdatefood";
            this.btnupdatefood.Size = new System.Drawing.Size(65, 92);
            this.btnupdatefood.TabIndex = 40;
            this.btnupdatefood.Text = "Sửa";
            this.btnupdatefood.UseVisualStyleBackColor = false;
            this.btnupdatefood.Click += new System.EventHandler(this.btnupdatefood_Click);
            // 
            // btnaddfood
            // 
            this.btnaddfood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnaddfood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfood.Location = new System.Drawing.Point(331, 140);
            this.btnaddfood.Name = "btnaddfood";
            this.btnaddfood.Size = new System.Drawing.Size(64, 92);
            this.btnaddfood.TabIndex = 39;
            this.btnaddfood.Text = "Thêm";
            this.btnaddfood.UseVisualStyleBackColor = false;
            this.btnaddfood.Click += new System.EventHandler(this.btnaddfood_Click);
            // 
            // danhsachmonan
            // 
            this.danhsachmonan.AllowUserToAddRows = false;
            this.danhsachmonan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachmonan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.danhsachmonan.Location = new System.Drawing.Point(25, 307);
            this.danhsachmonan.Name = "danhsachmonan";
            this.danhsachmonan.Size = new System.Drawing.Size(510, 150);
            this.danhsachmonan.TabIndex = 38;
            this.danhsachmonan.SelectionChanged += new System.EventHandler(this.danhsachmonan_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã món ăn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên món ăn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nguyên liệu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Hình ảnh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nguyện liệu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tên món ăn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mã món ăn:";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tab1);
            this.tabcontrol1.Controls.Add(this.tabPage2);
            this.tabcontrol1.Location = new System.Drawing.Point(3, 2);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(572, 494);
            this.tabcontrol1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 502);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnguyenlieu)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachmonan)).EndInit();
            this.tabcontrol1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbbkeyword;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.TextBox txtkeyword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView danhsachnguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.ComboBox cbbkeywordfood;
        private System.Windows.Forms.Button btnlistfood;
        private System.Windows.Forms.TextBox txtkeywordfood;
        private System.Windows.Forms.TextBox txtnamefood;
        private System.Windows.Forms.TextBox txtidfood;
        private System.Windows.Forms.Button btnfindfood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndeletefood;
        private System.Windows.Forms.Button btnupdatefood;
        private System.Windows.Forms.Button btnaddfood;
        private System.Windows.Forms.DataGridView danhsachmonan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btngetdialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btngetlist;
        private System.Windows.Forms.TextBox txtnguyenlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

