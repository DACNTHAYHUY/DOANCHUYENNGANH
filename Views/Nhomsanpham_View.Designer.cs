namespace DATN.Views
{
    partial class Nhomsanpham_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhomsanpham_View));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNhomsanpham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTennsp = new System.Windows.Forms.TextBox();
            this.txtMansp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomsanpham)).BeginInit();
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
            this.groupBox3.Controls.Add(this.dgvNhomsanpham);
            this.groupBox3.Location = new System.Drawing.Point(16, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(827, 329);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin";
            // 
            // dgvNhomsanpham
            // 
            this.dgvNhomsanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhomsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvNhomsanpham.Location = new System.Drawing.Point(6, 19);
            this.dgvNhomsanpham.Name = "dgvNhomsanpham";
            this.dgvNhomsanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhomsanpham.Size = new System.Drawing.Size(815, 304);
            this.dgvNhomsanpham.TabIndex = 10;
            this.dgvNhomsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomsanpham_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.btLuu);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Location = new System.Drawing.Point(16, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 68);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(395, 17);
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
            this.btHuy.Location = new System.Drawing.Point(303, 17);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 30);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.Location = new System.Drawing.Point(19, 19);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(77, 27);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtTennsp);
            this.groupBox1.Controls.Add(this.txtMansp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtTennsp
            // 
            this.txtTennsp.Location = new System.Drawing.Point(117, 51);
            this.txtTennsp.Name = "txtTennsp";
            this.txtTennsp.Size = new System.Drawing.Size(371, 20);
            this.txtTennsp.TabIndex = 1;
            // 
            // txtMansp
            // 
            this.txtMansp.Enabled = false;
            this.txtMansp.Location = new System.Drawing.Point(117, 24);
            this.txtMansp.Name = "txtMansp";
            this.txtMansp.Size = new System.Drawing.Size(189, 20);
            this.txtMansp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm sản phẩm";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.txtTimkiem);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(510, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 67);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(85, 24);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(235, 20);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.Text = "Nhập tên nhóm sản phẩm";
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            this.txtTimkiem.Enter += new System.EventHandler(this.txtTimkiem_Enter);
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
            this.label11.TabIndex = 0;
            this.label11.Text = "    Tìm kiếm";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mansp";
            this.Column1.HeaderText = "Mã nhóm sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tennsp";
            this.Column2.HeaderText = "Tên nhóm sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Nhomsanpham_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 510);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nhomsanpham_View";
            this.Text = "Nhomsanpham_View";
            this.Load += new System.EventHandler(this.Nhomsanpham_View_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomsanpham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvNhomsanpham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTennsp;
        private System.Windows.Forms.TextBox txtMansp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}