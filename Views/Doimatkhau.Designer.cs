namespace DATN.Views
{
    partial class Doimatkhau
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btDongy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMkm2 = new System.Windows.Forms.MaskedTextBox();
            this.txtMkm1 = new System.Windows.Forms.MaskedTextBox();
            this.txtMkc = new System.Windows.Forms.MaskedTextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btHuy);
            this.groupBox2.Controls.Add(this.btDongy);
            this.groupBox2.Location = new System.Drawing.Point(117, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(216, 19);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(109, 34);
            this.btHuy.TabIndex = 6;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            // 
            // btDongy
            // 
            this.btDongy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDongy.Location = new System.Drawing.Point(47, 19);
            this.btDongy.Name = "btDongy";
            this.btDongy.Size = new System.Drawing.Size(109, 34);
            this.btDongy.TabIndex = 5;
            this.btDongy.Text = "Đồng ý";
            this.btDongy.UseVisualStyleBackColor = true;
            this.btDongy.Click += new System.EventHandler(this.btDongy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMkm2);
            this.groupBox1.Controls.Add(this.txtMkm1);
            this.groupBox1.Controls.Add(this.txtMkc);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(117, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 169);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtMkm2
            // 
            this.txtMkm2.Location = new System.Drawing.Point(146, 140);
            this.txtMkm2.Name = "txtMkm2";
            this.txtMkm2.PasswordChar = '*';
            this.txtMkm2.Size = new System.Drawing.Size(236, 20);
            this.txtMkm2.TabIndex = 4;
            // 
            // txtMkm1
            // 
            this.txtMkm1.Location = new System.Drawing.Point(146, 104);
            this.txtMkm1.Name = "txtMkm1";
            this.txtMkm1.PasswordChar = '*';
            this.txtMkm1.Size = new System.Drawing.Size(236, 20);
            this.txtMkm1.TabIndex = 3;
            // 
            // txtMkc
            // 
            this.txtMkc.Location = new System.Drawing.Point(146, 67);
            this.txtMkc.Name = "txtMkc";
            this.txtMkc.PasswordChar = '*';
            this.txtMkc.Size = new System.Drawing.Size(236, 20);
            this.txtMkc.TabIndex = 2;
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(146, 28);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(236, 20);
            this.txtManv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới";
            // 
            // Doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doimatkhau";
            this.Text = "Doimatkhau";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doimatkhau_FormClosed);
            this.Load += new System.EventHandler(this.Doimatkhau_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btDongy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMkc;
        private System.Windows.Forms.MaskedTextBox txtMkm2;
        private System.Windows.Forms.MaskedTextBox txtMkm1;
        private System.Windows.Forms.Label label2;
    }
}