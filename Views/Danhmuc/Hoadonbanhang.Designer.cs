namespace DATN.Views.Danhmuc
{
    partial class Hoadonbanhang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgvHoadonban = new System.Windows.Forms.DataGridView();
            this.btBaocao = new System.Windows.Forms.Button();
            this.btXemchitiet = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonban)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(309, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm theo";
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
            "Mã khách hàng",
            "Tên khách hàng",
            "Ngày bán"});
            this.cbTimkiem.Location = new System.Drawing.Point(136, 78);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(172, 24);
            this.cbTimkiem.TabIndex = 2;
            this.cbTimkiem.Text = "Mã hóa đơn";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(314, 80);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(298, 22);
            this.txtTimkiem.TabIndex = 3;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // dgvHoadonban
            // 
            this.dgvHoadonban.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoadonban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoadonban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadonban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvHoadonban.Location = new System.Drawing.Point(7, 121);
            this.dgvHoadonban.Name = "dgvHoadonban";
            this.dgvHoadonban.Size = new System.Drawing.Size(837, 399);
            this.dgvHoadonban.TabIndex = 4;
            // 
            // btBaocao
            // 
            this.btBaocao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaocao.Location = new System.Drawing.Point(734, 77);
            this.btBaocao.Name = "btBaocao";
            this.btBaocao.Size = new System.Drawing.Size(110, 24);
            this.btBaocao.TabIndex = 5;
            this.btBaocao.Text = "Xuất báo cáo";
            this.btBaocao.UseVisualStyleBackColor = true;
            // 
            // btXemchitiet
            // 
            this.btXemchitiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btXemchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemchitiet.Location = new System.Drawing.Point(618, 78);
            this.btXemchitiet.Name = "btXemchitiet";
            this.btXemchitiet.Size = new System.Drawing.Size(110, 24);
            this.btXemchitiet.TabIndex = 19;
            this.btXemchitiet.Text = "Xem chi tiết";
            this.btXemchitiet.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mahdb";
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
            this.Column4.DataPropertyName = "Makh";
            this.Column4.HeaderText = "Mã khách hàng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tenkh";
            this.Column5.HeaderText = "Tên khách hàng";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ngayban";
            this.Column6.HeaderText = "Ngày bán";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Tongtien";
            this.Column7.HeaderText = "Tổng tiền";
            this.Column7.Name = "Column7";
            // 
            // Hoadonbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 521);
            this.Controls.Add(this.btXemchitiet);
            this.Controls.Add(this.btBaocao);
            this.Controls.Add(this.dgvHoadonban);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hoadonbanhang";
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.Hoadonbanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadonban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvHoadonban;
        private System.Windows.Forms.Button btBaocao;
        private System.Windows.Forms.Button btXemchitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}