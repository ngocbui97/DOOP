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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dropsave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            this.danhsachnguyenlieu = new System.Windows.Forms.DataGridView();
            this.btnlist = new System.Windows.Forms.Button();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbkeyword = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnguyenlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(119, 89);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(147, 22);
            this.txtid.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(119, 122);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(147, 22);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên nguyên liệu:";
            // 
            // dropsave
            // 
            this.dropsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropsave.FormattingEnabled = true;
            this.dropsave.Location = new System.Drawing.Point(119, 157);
            this.dropsave.Name = "dropsave";
            this.dropsave.Size = new System.Drawing.Size(147, 24);
            this.dropsave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kho lưu trữ:";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(290, 87);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(64, 92);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(360, 87);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(65, 92);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(431, 87);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(63, 92);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thêm nguyên liệu";
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(413, 56);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(81, 23);
            this.btnfind.TabIndex = 12;
            this.btnfind.Text = "tìm kiếm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // txtkeyword
            // 
            this.txtkeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkeyword.Location = new System.Drawing.Point(272, 57);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(135, 22);
            this.txtkeyword.TabIndex = 13;
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
            this.danhsachnguyenlieu.Location = new System.Drawing.Point(15, 254);
            this.danhsachnguyenlieu.Name = "danhsachnguyenlieu";
            this.danhsachnguyenlieu.Size = new System.Drawing.Size(484, 209);
            this.danhsachnguyenlieu.TabIndex = 7;
            this.danhsachnguyenlieu.SelectionChanged += new System.EventHandler(this.danhsachnguyenlieu_SelectionChanged);
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlist.Location = new System.Drawing.Point(290, 185);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(204, 63);
            this.btnlist.TabIndex = 15;
            this.btnlist.Text = "Danh sách";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
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
            // cbbkeyword
            // 
            this.cbbkeyword.FormattingEnabled = true;
            this.cbbkeyword.Items.AddRange(new object[] {
            "Mã món ăn",
            "Tên món ăn"});
            this.cbbkeyword.Location = new System.Drawing.Point(119, 56);
            this.cbbkeyword.Name = "cbbkeyword";
            this.cbbkeyword.Size = new System.Drawing.Size(147, 21);
            this.cbbkeyword.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 475);
            this.Controls.Add(this.cbbkeyword);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.txtkeyword);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.danhsachnguyenlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachnguyenlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.TextBox txtkeyword;
        private System.Windows.Forms.DataGridView danhsachnguyenlieu;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsave;
        private System.Windows.Forms.ComboBox cbbkeyword;
    }
}

