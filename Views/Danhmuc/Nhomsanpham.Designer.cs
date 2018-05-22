namespace DATN.Views.Danhmuc
{
    partial class Nhomsanpham
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
            this.btBaocao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNhomsanpham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // btBaocao
            // 
            this.btBaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaocao.Location = new System.Drawing.Point(678, 54);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(110, 25);
            this.btBaocao.TabIndex = 34;
            this.btBaocao.Text = "Xuất báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Danh sách nhóm sản phẩm";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(360, 55);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(298, 22);
            this.txtTimkiem.TabIndex = 31;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "Mã nhóm sản phẩm",
            "Tên nhóm sản phẩm"});
            this.cbTimkiem.Location = new System.Drawing.Point(182, 53);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(172, 24);
            this.cbTimkiem.TabIndex = 30;
            this.cbTimkiem.Text = "Mã nhóm sản phẩm";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tìm kiếm theo";
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
            this.dgvNhomsanpham.Location = new System.Drawing.Point(12, 111);
            this.dgvNhomsanpham.Name = "dgvNhomsanpham";
            this.dgvNhomsanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhomsanpham.Size = new System.Drawing.Size(824, 404);
            this.dgvNhomsanpham.TabIndex = 35;
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
            // Nhomsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 527);
            this.Controls.Add(this.dgvNhomsanpham);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.label2);
            this.Name = "Nhomsanpham";
            this.Text = "Nhóm sản phẩm";
            this.Load += new System.EventHandler(this.Nhomsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvNhomsanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}