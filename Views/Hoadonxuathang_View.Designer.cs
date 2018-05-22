namespace DATN.Views
{
    partial class Hoadonxuathang_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadonxuathang_View));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoadonxuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXem = new System.Windows.Forms.Button();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.dtNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.txtMahdx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonxuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvHoadonxuat);
            this.groupBox3.Location = new System.Drawing.Point(9, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 291);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin";
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
            this.Column3});
            this.dgvHoadonxuat.Location = new System.Drawing.Point(7, 14);
            this.dgvHoadonxuat.Name = "dgvHoadonxuat";
            this.dgvHoadonxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoadonxuat.Size = new System.Drawing.Size(823, 271);
            this.dgvHoadonxuat.TabIndex = 4;
            this.dgvHoadonxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoadonxuat_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mahdx";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Manv";
            this.Column2.HeaderText = "Mã nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngayxuat";
            this.Column3.HeaderText = "Ngày xuất";
            this.Column3.Name = "Column3";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Location = new System.Drawing.Point(9, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 68);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(397, 17);
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
            this.btHuy.Location = new System.Drawing.Point(300, 17);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 30);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.Location = new System.Drawing.Point(207, 17);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 30);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
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
            this.btThem.Location = new System.Drawing.Point(16, 19);
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
            this.groupBox1.Controls.Add(this.btXem);
            this.groupBox1.Controls.Add(this.cbManv);
            this.groupBox1.Controls.Add(this.dtNgayxuat);
            this.groupBox1.Controls.Add(this.txtMahdx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 108);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.Image = ((System.Drawing.Image)(resources.GetObject("btXem.Image")));
            this.btXem.Location = new System.Drawing.Point(703, 68);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(119, 23);
            this.btXem.TabIndex = 4;
            this.btXem.Text = "Xem chi tiết";
            this.btXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(117, 50);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(165, 21);
            this.cbManv.TabIndex = 3;
            // 
            // dtNgayxuat
            // 
            this.dtNgayxuat.CustomFormat = "yyyy/MM/dd";
            this.dtNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayxuat.Location = new System.Drawing.Point(386, 24);
            this.dtNgayxuat.Name = "dtNgayxuat";
            this.dtNgayxuat.Size = new System.Drawing.Size(165, 20);
            this.dtNgayxuat.TabIndex = 2;
            // 
            // txtMahdx
            // 
            this.txtMahdx.Enabled = false;
            this.txtMahdx.Location = new System.Drawing.Point(117, 24);
            this.txtMahdx.Name = "txtMahdx";
            this.txtMahdx.Size = new System.Drawing.Size(165, 20);
            this.txtMahdx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 27);
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
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtTimkiem);
            this.groupBox5.Location = new System.Drawing.Point(507, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 67);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(6, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "    Tìm kiếm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(85, 24);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(239, 20);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.Text = "Nhập đúng mã hoặc 2 số cuối mã hóa đơn xuất";
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            this.txtTimkiem.Enter += new System.EventHandler(this.txtTimkiem_Enter);
            // 
            // Hoadonxuathang_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 512);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hoadonxuathang_View";
            this.Text = "Quản lý hóa đơn xuất hàng";
            this.Load += new System.EventHandler(this.Hoadonxuathang_View_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonxuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoadonxuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.DateTimePicker dtNgayxuat;
        private System.Windows.Forms.TextBox txtMahdx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btXem;
    }
}