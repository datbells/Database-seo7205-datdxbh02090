namespace trangchu
{
    partial class Trangchu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.bthThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản Lý Sản Phẩm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quản Lý Khách Hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quản Lý Nhân Viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(596, 70);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(104, 65);
            this.btnDatHang.TabIndex = 3;
            this.btnDatHang.Text = "Quản Lý Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // bthThoat
            // 
            this.bthThoat.Location = new System.Drawing.Point(652, 376);
            this.bthThoat.Name = "bthThoat";
            this.bthThoat.Size = new System.Drawing.Size(96, 38);
            this.bthThoat.TabIndex = 4;
            this.bthThoat.Text = "Thoát";
            this.bthThoat.UseVisualStyleBackColor = true;
            this.bthThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::trangchu.Properties.Resources.istockphoto_1387073187_612x6122;
            this.ClientSize = new System.Drawing.Size(828, 449);
            this.Controls.Add(this.bthThoat);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Trangchu";
            this.Text = "Trangchu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trangchu_FormClosing);
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Button bthThoat;
    }
}