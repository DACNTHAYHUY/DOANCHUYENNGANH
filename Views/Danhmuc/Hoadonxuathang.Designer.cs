namespace DATN.Views.Danhmuc
{
    partial class Hoadonxuathang
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
            this.dgvHoadonxuat = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXemchitiet = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btBaocao
            // 
            this.btBaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaocao.Location = new System.Drawing.Point(730, 71);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(110, 24);
            this.btBaocao.TabIndex = 17;
            this.btBaocao.Text = "Xuất báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
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
            this.dgvHoadonxuat.Location = new System.Drawing.Point(5, 111);
            this.dgvHoadonxuat.Name = "dgvHoadonxuat";
            this.dgvHoadonxuat.Size = new System.Drawing.Size(835, 407);
            this.dgvHoadonxuat.TabIndex = 16;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(311, 73);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(298, 22);
            this.txtTimkiem.TabIndex = 15;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Mã nhân viên",
            "Tên nhân viên",
            "Ngày xuất"});
            this.cbTimkiem.Location = new System.Drawing.Point(133, 71);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(172, 24);
            this.cbTimkiem.TabIndex = 14;
            this.cbTimkiem.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(306, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hóa đơn xuất hàng";
            // 
            // btXemchitiet
            // 
            this.btXemchitiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXemchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemchitiet.Location = new System.Drawing.Point(614, 72);
            this.btXemchitiet.Name = "btXemchitiet";
            this.btXemchitiet.Size = new System.Drawing.Size(110, 24);
            this.btXemchitiet.TabIndex = 17;
            this.btXemchitiet.Text = "Xem chi tiết";
            this.btXemchitiet.UseVisualStyleBackColor = true;
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
            this.Column3.DataPropertyName = "Tennv";
            this.Column3.HeaderText = "Tên nhân viên";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Ngayxuat";
            this.Column4.HeaderText = "Ngày xuất";
            this.Column4.Name = "Column4";
            // 
            // Hoadonxuathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 520);
            this.Controls.Add(this.btXemchitiet);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.dgvHoadonxuat);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hoadonxuathang";
            this.Text = "Hóa đơn xuất hàng";
            this.Load += new System.EventHandler(this.Hoadonxuathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.DataGridView dgvHoadonxuat;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXemchitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}