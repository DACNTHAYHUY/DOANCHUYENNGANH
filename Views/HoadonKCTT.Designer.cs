namespace DATN.Views
{
    partial class HoadonKCTT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMakh = new System.Windows.Forms.ComboBox();
            this.dtNgayban = new System.Windows.Forms.DateTimePicker();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtMahdb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTaohd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMakh);
            this.groupBox1.Controls.Add(this.dtNgayban);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.txtMahdb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(135, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 172);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cbMakh
            // 
            this.cbMakh.FormattingEnabled = true;
            this.cbMakh.Location = new System.Drawing.Point(117, 88);
            this.cbMakh.Name = "cbMakh";
            this.cbMakh.Size = new System.Drawing.Size(165, 21);
            this.cbMakh.TabIndex = 3;
            this.cbMakh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbMakh_KeyDown);
            // 
            // dtNgayban
            // 
            this.dtNgayban.CustomFormat = "yyyy/MM/dd";
            this.dtNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayban.Location = new System.Drawing.Point(117, 124);
            this.dtNgayban.Name = "dtNgayban";
            this.dtNgayban.Size = new System.Drawing.Size(165, 20);
            this.dtNgayban.TabIndex = 2;
            this.dtNgayban.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtNgayban_KeyDown);
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(117, 52);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(165, 20);
            this.txtManv.TabIndex = 1;
            // 
            // txtMahdb
            // 
            this.txtMahdb.Enabled = false;
            this.txtMahdb.Location = new System.Drawing.Point(117, 24);
            this.txtMahdb.Name = "txtMahdb";
            this.txtMahdb.Size = new System.Drawing.Size(165, 20);
            this.txtMahdb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btTaohd
            // 
            this.btTaohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaohd.Location = new System.Drawing.Point(349, 255);
            this.btTaohd.Name = "btTaohd";
            this.btTaohd.Size = new System.Drawing.Size(116, 23);
            this.btTaohd.TabIndex = 14;
            this.btTaohd.Text = "Tạo hóa đơn";
            this.btTaohd.UseVisualStyleBackColor = true;
            this.btTaohd.Click += new System.EventHandler(this.btTaohd_Click);
            // 
            // HoadonKCTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 356);
            this.Controls.Add(this.btTaohd);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoadonKCTT";
            this.Text = "HoadonKCTT";
            this.Load += new System.EventHandler(this.HoadonKCTT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMakh;
        private System.Windows.Forms.DateTimePicker dtNgayban;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtMahdb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTaohd;
    }
}