namespace DATN.Views
{
    partial class HoadonKCCTT
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
            this.btTaohd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayban = new System.Windows.Forms.DateTimePicker();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.txtMahdb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btTaohd
            // 
            this.btTaohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaohd.Location = new System.Drawing.Point(350, 296);
            this.btTaohd.Name = "btTaohd";
            this.btTaohd.Size = new System.Drawing.Size(116, 23);
            this.btTaohd.TabIndex = 16;
            this.btTaohd.Text = "Tạo hóa đơn";
            this.btTaohd.UseVisualStyleBackColor = true;
            this.btTaohd.Click += new System.EventHandler(this.btTaohd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtNgayban);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtTenkh);
            this.groupBox1.Controls.Add(this.txtMakh);
            this.groupBox1.Controls.Add(this.txtMahdb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(88, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 268);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // dtNgayban
            // 
            this.dtNgayban.CustomFormat = "yyyy/MM/dd";
            this.dtNgayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayban.Location = new System.Drawing.Point(131, 211);
            this.dtNgayban.Name = "dtNgayban";
            this.dtNgayban.Size = new System.Drawing.Size(214, 20);
            this.dtNgayban.TabIndex = 2;
            this.dtNgayban.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtNgayban_KeyDown);
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(131, 52);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(214, 20);
            this.txtManv.TabIndex = 1;
            this.txtManv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMahdb_KeyDown);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(131, 176);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(214, 20);
            this.txtSdt.TabIndex = 1;
            this.txtSdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSdt_KeyDown);
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(131, 112);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.Size = new System.Drawing.Size(214, 20);
            this.txtTenkh.TabIndex = 1;
            this.txtTenkh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenkh_KeyDown);
            // 
            // txtMakh
            // 
            this.txtMakh.Enabled = false;
            this.txtMakh.Location = new System.Drawing.Point(131, 82);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.Size = new System.Drawing.Size(214, 20);
            this.txtMakh.TabIndex = 1;
            this.txtMakh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMahdb_KeyDown);
            // 
            // txtMahdb
            // 
            this.txtMahdb.Enabled = false;
            this.txtMahdb.Location = new System.Drawing.Point(131, 24);
            this.txtMahdb.Name = "txtMahdb";
            this.txtMahdb.Size = new System.Drawing.Size(214, 20);
            this.txtMahdb.TabIndex = 1;
            this.txtMahdb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMahdb_KeyDown);
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
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày bán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNu);
            this.groupBox3.Controls.Add(this.rbNam);
            this.groupBox3.Location = new System.Drawing.Point(131, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 30);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(151, 9);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 2;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(18, 9);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 2;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // HoadonKCCTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 354);
            this.Controls.Add(this.btTaohd);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoadonKCCTT";
            this.Text = "HoadonKCCTT";
            this.Load += new System.EventHandler(this.HoadonKCCTT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTaohd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayban;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtMahdb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}