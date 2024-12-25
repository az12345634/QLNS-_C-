namespace QLNHANSU
{
    partial class DANGNHAP
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(221, 303);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(386, 33);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Lỗi : \r\n";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(226, 244);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(180, 40);
            this.btndangnhap.TabIndex = 13;
            this.btndangnhap.Text = "Login";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(324, 181);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(267, 34);
            this.txtMatKhau.TabIndex = 12;
            // 
            // txtTenTKhoan
            // 
            this.txtTenTKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTKhoan.Location = new System.Drawing.Point(324, 107);
            this.txtTenTKhoan.Name = "txtTenTKhoan";
            this.txtTenTKhoan.Size = new System.Drawing.Size(267, 34);
            this.txtTenTKhoan.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu :\r\n\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên Tài Khoản : \r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Nhập\r\n\r\n\r\n";
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DANGNHAP";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}