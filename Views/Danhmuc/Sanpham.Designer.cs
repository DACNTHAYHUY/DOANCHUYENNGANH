namespace DATN.Views.Danhmuc
{
    partial class Sanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.btBaocao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btBaocao
            // 
            this.btBaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaocao.Image = ((System.Drawing.Image)(resources.GetObject("btBaocao.Image")));
            this.btBaocao.Location = new System.Drawing.Point(678, 59);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(132, 25);
            this.btBaocao.TabIndex = 40;
            this.btBaocao.Text = "Xuất báo cáo";
            this.btBaocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBaocao.UseVisualStyleBackColor = true;
            this.btBaocao.Click += new System.EventHandler(this.btBaocao_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Danh sách sản phẩm cửa hàng";
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvSanpham.Location = new System.Drawing.Point(6, 103);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.Size = new System.Drawing.Size(837, 421);
            this.dgvSanpham.TabIndex = 38;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(360, 60);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(298, 22);
            this.txtTimkiem.TabIndex = 37;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "Nhóm sản phẩm",
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Số lượng",
            "Loại"});
            this.cbTimkiem.Location = new System.Drawing.Point(182, 58);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(172, 24);
            this.cbTimkiem.TabIndex = 36;
            this.cbTimkiem.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tennsp";
            this.Column1.HeaderText = "Tên nhóm sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Masp";
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tensp";
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Soluong";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Giaban";
            this.Column5.HeaderText = "Giá bán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Loai";
            this.Column6.HeaderText = "Loại";
            this.Column6.Name = "Column6";
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 539);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.label2);
            this.Name = "Sanpham";
            this.Text = "Sản phẩm cửa hàng";
            this.Load += new System.EventHandler(this.Sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}