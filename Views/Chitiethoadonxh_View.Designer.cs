namespace DATN.Views
{
    partial class Chitiethoadonxh_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chitiethoadonxh_View));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHoadonxuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.btTaomoi = new System.Windows.Forms.Button();
            this.txtMahdx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMacthdx = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cbMasp = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btIn = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonxuat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(443, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 67);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(19, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "    Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Nhập mã hóa đơn hoặc 2 số cuối của mã hóa đơn xuất";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvHoadonxuat);
            this.groupBox4.Location = new System.Drawing.Point(1, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(839, 222);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bảng thông tin";
            // 
            // dgvHoadonxuat
            // 
            this.dgvHoadonxuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoadonxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadonxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadonxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvHoadonxuat.Location = new System.Drawing.Point(6, 14);
            this.dgvHoadonxuat.Name = "dgvHoadonxuat";
            this.dgvHoadonxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoadonxuat.Size = new System.Drawing.Size(823, 202);
            this.dgvHoadonxuat.TabIndex = 4;
            this.dgvHoadonxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadonxuat_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Macthdx";
            this.Column1.HeaderText = "Mã chi tiết hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Mahdx";
            this.Column2.HeaderText = "Mã hóa đơn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Masp";
            this.Column3.HeaderText = "Mã sản phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btHuy);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Location = new System.Drawing.Point(8, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 68);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(210, 17);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 30);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Image = ((System.Drawing.Image)(resources.GetObject("btHuy.Image")));
            this.btHuy.Location = new System.Drawing.Point(314, 17);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 30);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.Location = new System.Drawing.Point(114, 17);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 30);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(17, 19);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 30);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dtNgayxuat);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.btTaomoi);
            this.groupBox1.Controls.Add(this.txtMahdx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 89);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtNgayxuat
            // 
            this.dtNgayxuat.CustomFormat = "yyyy/MM/dd";
            this.dtNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayxuat.Location = new System.Drawing.Point(386, 24);
            this.dtNgayxuat.Name = "dtNgayxuat";
            this.dtNgayxuat.Size = new System.Drawing.Size(178, 20);
            this.dtNgayxuat.TabIndex = 2;
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(117, 56);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(178, 20);
            this.txtManv.TabIndex = 1;
            // 
            // btTaomoi
            // 
            this.btTaomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaomoi.Image = ((System.Drawing.Image)(resources.GetObject("btTaomoi.Image")));
            this.btTaomoi.Location = new System.Drawing.Point(728, 52);
            this.btTaomoi.Name = "btTaomoi";
            this.btTaomoi.Size = new System.Drawing.Size(90, 27);
            this.btTaomoi.TabIndex = 2;
            this.btTaomoi.Text = "Tạo Mới";
            this.btTaomoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaomoi.UseVisualStyleBackColor = true;
            this.btTaomoi.Click += new System.EventHandler(this.btTaomoi_Click);
            // 
            // txtMahdx
            // 
            this.txtMahdx.Enabled = false;
            this.txtMahdx.Location = new System.Drawing.Point(117, 24);
            this.txtMahdx.Name = "txtMahdx";
            this.txtMahdx.Size = new System.Drawing.Size(178, 20);
            this.txtMahdx.TabIndex = 1;
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
            this.label5.Location = new System.Drawing.Point(313, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã chi tiết";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // txtMacthdx
            // 
            this.txtMacthdx.Enabled = false;
            this.txtMacthdx.Location = new System.Drawing.Point(117, 24);
            this.txtMacthdx.Name = "txtMacthdx";
            this.txtMacthdx.Size = new System.Drawing.Size(165, 20);
            this.txtMacthdx.TabIndex = 1;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(386, 19);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(178, 20);
            this.txtSoluong.TabIndex = 1;
            // 
            // cbMasp
            // 
            this.cbMasp.FormattingEnabled = true;
            this.cbMasp.Location = new System.Drawing.Point(117, 51);
            this.cbMasp.Name = "cbMasp";
            this.cbMasp.Size = new System.Drawing.Size(165, 21);
            this.cbMasp.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btIn);
            this.groupBox2.Controls.Add(this.cbMasp);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.txtMacthdx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 108);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.Image = ((System.Drawing.Image)(resources.GetObject("btIn.Image")));
            this.btIn.Location = new System.Drawing.Point(696, 54);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(122, 30);
            this.btIn.TabIndex = 19;
            this.btIn.Text = "Xuất hóa đơn";
            this.btIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // Chitiethoadonxh_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 527);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chitiethoadonxh_View";
            this.Text = "Hóa đơn xuất hàng";
            this.Load += new System.EventHandler(this.Chitiethoadonxh_View_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonxuat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHoadonxuat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayxuat;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Button btTaomoi;
        private System.Windows.Forms.TextBox txtMahdx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMacthdx;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cbMasp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btIn;
    }
}