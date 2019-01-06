namespace Demo_DOOP_FRAMEWORK
{
    partial class DanhSachNguyenLieu
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnthaydoi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(405, 130);
            this.checkedListBox1.TabIndex = 7;
            // 
            // btnthaydoi
            // 
            this.btnthaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthaydoi.Location = new System.Drawing.Point(12, 148);
            this.btnthaydoi.Name = "btnthaydoi";
            this.btnthaydoi.Size = new System.Drawing.Size(405, 62);
            this.btnthaydoi.TabIndex = 10;
            this.btnthaydoi.Text = "Lưu tạm thời";
            this.btnthaydoi.UseVisualStyleBackColor = true;
            this.btnthaydoi.Click += new System.EventHandler(this.btnthaydoi_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 124);
            this.listBox1.TabIndex = 11;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxacnhan.Location = new System.Drawing.Point(12, 346);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(405, 71);
            this.btnxacnhan.TabIndex = 12;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // DanhSachNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 431);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnthaydoi);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "DanhSachNguyenLieu";
            this.Text = "DanhSachNguyenLieu";
            this.Load += new System.EventHandler(this.DanhSachNguyenLieu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnthaydoi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnxacnhan;
    }
}