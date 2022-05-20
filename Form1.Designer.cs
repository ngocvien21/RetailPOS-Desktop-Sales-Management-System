namespace fLogin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btTHOAT = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbHTMK = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTHOAT
            // 
            this.btTHOAT.BackColor = System.Drawing.Color.PowderBlue;
            this.btTHOAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btTHOAT.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btTHOAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTHOAT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTHOAT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTHOAT.Location = new System.Drawing.Point(406, 221);
            this.btTHOAT.Margin = new System.Windows.Forms.Padding(4);
            this.btTHOAT.Name = "btTHOAT";
            this.btTHOAT.Size = new System.Drawing.Size(150, 36);
            this.btTHOAT.TabIndex = 8;
            this.btTHOAT.Text = "Thoát";
            this.btTHOAT.UseVisualStyleBackColor = false;
            this.btTHOAT.Click += new System.EventHandler(this.btTHOAT_Click_1);
            // 
            // btDN
            // 
            this.btDN.BackColor = System.Drawing.Color.PowderBlue;
            this.btDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDN.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDN.Location = new System.Drawing.Point(126, 221);
            this.btDN.Margin = new System.Windows.Forms.Padding(4);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(150, 36);
            this.btDN.TabIndex = 9;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = false;
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(214, 88);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(342, 22);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(214, 174);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(342, 22);
            this.txtMatKhau.TabIndex = 11;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::fLogin.Properties.Resources.shoppingbag_icon;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 136);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cbHTMK
            // 
            this.cbHTMK.AutoSize = true;
            this.cbHTMK.BackColor = System.Drawing.Color.Transparent;
            this.cbHTMK.Location = new System.Drawing.Point(585, 176);
            this.cbHTMK.Name = "cbHTMK";
            this.cbHTMK.Size = new System.Drawing.Size(140, 21);
            this.cbHTMK.TabIndex = 15;
            this.cbHTMK.Text = "Hiển thị mật khẩu";
            this.cbHTMK.UseVisualStyleBackColor = false;
            this.cbHTMK.CheckedChanged += new System.EventHandler(this.cbHTMK_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fLogin.Properties.Resources.pink1;
            this.ClientSize = new System.Drawing.Size(768, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbHTMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.btTHOAT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTHOAT;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbHTMK;
        private System.Windows.Forms.Label label3;
    }
}

