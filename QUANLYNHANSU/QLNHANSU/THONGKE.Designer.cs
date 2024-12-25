namespace QLNHANSU
{
    partial class THONGKE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THONGKE));
            this.lblSoluongtk = new System.Windows.Forms.Label();
            this.lblSoluongnv = new System.Windows.Forms.Label();
            this.lblSoluonghopdong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoluongtk
            // 
            this.lblSoluongtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongtk.Location = new System.Drawing.Point(506, 63);
            this.lblSoluongtk.Name = "lblSoluongtk";
            this.lblSoluongtk.Size = new System.Drawing.Size(342, 50);
            this.lblSoluongtk.TabIndex = 3;
            this.lblSoluongtk.Text = "Số lượng tài khoản đã cấp : ";
            // 
            // lblSoluongnv
            // 
            this.lblSoluongnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluongnv.Location = new System.Drawing.Point(67, 63);
            this.lblSoluongnv.Name = "lblSoluongnv";
            this.lblSoluongnv.Size = new System.Drawing.Size(394, 50);
            this.lblSoluongnv.TabIndex = 0;
            this.lblSoluongnv.Text = "Số lượng nhân viên : \r\n";
            // 
            // lblSoluonghopdong
            // 
            this.lblSoluonghopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluonghopdong.Location = new System.Drawing.Point(67, 144);
            this.lblSoluonghopdong.Name = "lblSoluonghopdong";
            this.lblSoluonghopdong.Size = new System.Drawing.Size(394, 50);
            this.lblSoluonghopdong.TabIndex = 1;
            this.lblSoluonghopdong.Text = "Số lượng hợp đồng : \r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Magneto", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 52);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nguyễn Minh Thái\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 101);
            this.label1.TabIndex = 18;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(918, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoluongtk);
            this.groupBox1.Controls.Add(this.lblSoluongnv);
            this.groupBox1.Controls.Add(this.lblSoluonghopdong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(103, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 243);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // THONGKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "THONGKE";
            this.Text = "Thống kê tổng quan";
            this.Load += new System.EventHandler(this.THONGKE_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSoluongtk;
        private System.Windows.Forms.Label lblSoluongnv;
        private System.Windows.Forms.Label lblSoluonghopdong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}