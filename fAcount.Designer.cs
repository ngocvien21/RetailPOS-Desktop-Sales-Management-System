namespace fLogin
{
    partial class fAcount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAcount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btQL = new System.Windows.Forms.Button();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.btTIMKIEM = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXOA = new System.Windows.Forms.Button();
            this.btLAMMOI = new System.Windows.Forms.Button();
            this.btKHOITAO = new System.Windows.Forms.Button();
            this.btCAPNHAT = new System.Windows.Forms.Button();
            this.btTHEM = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grQLTK = new System.Windows.Forms.DataGridView();
            this.TenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grQLTK)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.grQLTK);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 762);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btQL);
            this.panel6.Controls.Add(this.txtTIMKIEM);
            this.panel6.Controls.Add(this.btTIMKIEM);
            this.panel6.Location = new System.Drawing.Point(45, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1183, 68);
            this.panel6.TabIndex = 20;
            // 
            // btQL
            // 
            this.btQL.BackColor = System.Drawing.Color.PowderBlue;
            this.btQL.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQL.Location = new System.Drawing.Point(1053, 14);
            this.btQL.Margin = new System.Windows.Forms.Padding(4);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(100, 33);
            this.btQL.TabIndex = 16;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = false;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Location = new System.Drawing.Point(20, 18);
            this.txtTIMKIEM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(214, 22);
            this.txtTIMKIEM.TabIndex = 15;
            // 
            // btTIMKIEM
            // 
            this.btTIMKIEM.BackColor = System.Drawing.Color.LightSalmon;
            this.btTIMKIEM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btTIMKIEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTIMKIEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTIMKIEM.ForeColor = System.Drawing.Color.Black;
            this.btTIMKIEM.Image = global::fLogin.Properties.Resources.search;
            this.btTIMKIEM.Location = new System.Drawing.Point(242, 4);
            this.btTIMKIEM.Margin = new System.Windows.Forms.Padding(4);
            this.btTIMKIEM.Name = "btTIMKIEM";
            this.btTIMKIEM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btTIMKIEM.Size = new System.Drawing.Size(142, 43);
            this.btTIMKIEM.TabIndex = 14;
            this.btTIMKIEM.Text = "Tìm kiếm";
            this.btTIMKIEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTIMKIEM.UseVisualStyleBackColor = false;
            this.btTIMKIEM.Click += new System.EventHandler(this.btTIMKIEM_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXOA);
            this.panel3.Controls.Add(this.btLAMMOI);
            this.panel3.Controls.Add(this.btKHOITAO);
            this.panel3.Controls.Add(this.btCAPNHAT);
            this.panel3.Controls.Add(this.btTHEM);
            this.panel3.Location = new System.Drawing.Point(1098, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 224);
            this.panel3.TabIndex = 19;
            // 
            // btXOA
            // 
            this.btXOA.BackColor = System.Drawing.Color.PowderBlue;
            this.btXOA.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btXOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXOA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXOA.Location = new System.Drawing.Point(4, 182);
            this.btXOA.Margin = new System.Windows.Forms.Padding(4);
            this.btXOA.Name = "btXOA";
            this.btXOA.Size = new System.Drawing.Size(100, 38);
            this.btXOA.TabIndex = 23;
            this.btXOA.Text = "Xóa";
            this.btXOA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXOA.UseVisualStyleBackColor = false;
            this.btXOA.Click += new System.EventHandler(this.btXOA_Click);
            // 
            // btLAMMOI
            // 
            this.btLAMMOI.BackColor = System.Drawing.Color.PowderBlue;
            this.btLAMMOI.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btLAMMOI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLAMMOI.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLAMMOI.Location = new System.Drawing.Point(4, 140);
            this.btLAMMOI.Margin = new System.Windows.Forms.Padding(4);
            this.btLAMMOI.Name = "btLAMMOI";
            this.btLAMMOI.Size = new System.Drawing.Size(100, 38);
            this.btLAMMOI.TabIndex = 22;
            this.btLAMMOI.Text = "Làm Mới";
            this.btLAMMOI.UseVisualStyleBackColor = false;
            this.btLAMMOI.Click += new System.EventHandler(this.btLAMMOI_Click);
            // 
            // btKHOITAO
            // 
            this.btKHOITAO.BackColor = System.Drawing.Color.PowderBlue;
            this.btKHOITAO.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btKHOITAO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKHOITAO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKHOITAO.Location = new System.Drawing.Point(4, 94);
            this.btKHOITAO.Margin = new System.Windows.Forms.Padding(4);
            this.btKHOITAO.Name = "btKHOITAO";
            this.btKHOITAO.Size = new System.Drawing.Size(100, 38);
            this.btKHOITAO.TabIndex = 21;
            this.btKHOITAO.Text = "Khởi tạo";
            this.btKHOITAO.UseVisualStyleBackColor = false;
            this.btKHOITAO.Click += new System.EventHandler(this.btKHOITAO_Click);
            // 
            // btCAPNHAT
            // 
            this.btCAPNHAT.BackColor = System.Drawing.Color.PowderBlue;
            this.btCAPNHAT.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btCAPNHAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCAPNHAT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCAPNHAT.Location = new System.Drawing.Point(4, 50);
            this.btCAPNHAT.Margin = new System.Windows.Forms.Padding(4);
            this.btCAPNHAT.Name = "btCAPNHAT";
            this.btCAPNHAT.Size = new System.Drawing.Size(100, 38);
            this.btCAPNHAT.TabIndex = 20;
            this.btCAPNHAT.Text = "Cập nhật";
            this.btCAPNHAT.UseVisualStyleBackColor = false;
            this.btCAPNHAT.Click += new System.EventHandler(this.btCAPNHAT_Click);
            // 
            // btTHEM
            // 
            this.btTHEM.BackColor = System.Drawing.Color.PowderBlue;
            this.btTHEM.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btTHEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTHEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTHEM.Location = new System.Drawing.Point(4, 4);
            this.btTHEM.Margin = new System.Windows.Forms.Padding(4);
            this.btTHEM.Name = "btTHEM";
            this.btTHEM.Size = new System.Drawing.Size(100, 38);
            this.btTHEM.TabIndex = 12;
            this.btTHEM.Text = "Thêm";
            this.btTHEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTHEM.UseVisualStyleBackColor = false;
            this.btTHEM.Click += new System.EventHandler(this.btTHEM_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::fLogin.Properties.Resources.pink2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Controls.Add(this.txtTenDangNhap);
            this.panel4.Controls.Add(this.txtTenHienThi);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(341, 548);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 173);
            this.panel4.TabIndex = 17;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(169, 108);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(376, 22);
            this.txtMatKhau.TabIndex = 8;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(169, 63);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(376, 22);
            this.txtTenDangNhap.TabIndex = 7;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(169, 23);
            this.txtTenHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(376, 22);
            this.txtTenHienThi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên hiển thị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // grQLTK
            // 
            this.grQLTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grQLTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHienThi,
            this.TenDangNhap,
            this.MatKhau});
            this.grQLTK.Location = new System.Drawing.Point(12, 190);
            this.grQLTK.Name = "grQLTK";
            this.grQLTK.RowTemplate.Height = 24;
            this.grQLTK.Size = new System.Drawing.Size(1234, 324);
            this.grQLTK.TabIndex = 16;
            // 
            // TenHienThi
            // 
            this.TenHienThi.DataPropertyName = "TenHienThi";
            this.TenHienThi.HeaderText = "Tên hiển thị";
            this.TenHienThi.Name = "TenHienThi";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::fLogin.Properties.Resources.pink1;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(37, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 68);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::fLogin.Properties.Resources.pink1;
            this.label1.Location = new System.Drawing.Point(424, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // fAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 777);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fAcount";
            this.Text = "TÀI KHOẢN";
            this.Load += new System.EventHandler(this.fAcount_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grQLTK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btQL;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.Button btTIMKIEM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXOA;
        private System.Windows.Forms.Button btLAMMOI;
        private System.Windows.Forms.Button btKHOITAO;
        private System.Windows.Forms.Button btCAPNHAT;
        private System.Windows.Forms.Button btTHEM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grQLTK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}