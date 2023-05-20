namespace fLogin
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btTIMKIEM = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXOA = new System.Windows.Forms.Button();
            this.btLAMMOI = new System.Windows.Forms.Button();
            this.btKHOITAO = new System.Windows.Forms.Button();
            this.btCAPNHAT = new System.Windows.Forms.Button();
            this.btTHEM = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbKieuCV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KieuCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grNV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.grNV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 757);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btTIMKIEM);
            this.panel6.Controls.Add(this.btQL);
            this.panel6.Controls.Add(this.txtTIMKIEM);
            this.panel6.Location = new System.Drawing.Point(45, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1183, 68);
            this.panel6.TabIndex = 20;
            // 
            // btTIMKIEM
            // 
            this.btTIMKIEM.BackColor = System.Drawing.Color.LightSalmon;
            this.btTIMKIEM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btTIMKIEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTIMKIEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTIMKIEM.ForeColor = System.Drawing.Color.Black;
            this.btTIMKIEM.Image = global::fLogin.Properties.Resources.search;
            this.btTIMKIEM.Location = new System.Drawing.Point(242, 9);
            this.btTIMKIEM.Margin = new System.Windows.Forms.Padding(4);
            this.btTIMKIEM.Name = "btTIMKIEM";
            this.btTIMKIEM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btTIMKIEM.Size = new System.Drawing.Size(135, 43);
            this.btTIMKIEM.TabIndex = 17;
            this.btTIMKIEM.Text = "Tìm kiếm";
            this.btTIMKIEM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTIMKIEM.UseVisualStyleBackColor = false;
            this.btTIMKIEM.Click += new System.EventHandler(this.btTIMKIEM_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btXOA);
            this.panel3.Controls.Add(this.btLAMMOI);
            this.panel3.Controls.Add(this.btKHOITAO);
            this.panel3.Controls.Add(this.btCAPNHAT);
            this.panel3.Controls.Add(this.btTHEM);
            this.panel3.Location = new System.Drawing.Point(1140, 530);
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
            // panel5
            // 
            this.panel5.BackgroundImage = global::fLogin.Properties.Resources.pink2;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.txtDiaChi);
            this.panel5.Controls.Add(this.cbKieuCV);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtChucVu);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(584, 558);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 173);
            this.panel5.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 23);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(376, 22);
            this.txtDiaChi.TabIndex = 17;
            // 
            // cbKieuCV
            // 
            this.cbKieuCV.FormattingEnabled = true;
            this.cbKieuCV.Items.AddRange(new object[] {
            "Full time",
            "Part time"});
            this.cbKieuCV.Location = new System.Drawing.Point(157, 101);
            this.cbKieuCV.Margin = new System.Windows.Forms.Padding(4);
            this.cbKieuCV.Name = "cbKieuCV";
            this.cbKieuCV.Size = new System.Drawing.Size(376, 24);
            this.cbKieuCV.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(157, 62);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(376, 22);
            this.txtChucVu.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Chức vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kiểu công việc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::fLogin.Properties.Resources.pink2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.cbGioiTinh);
            this.panel4.Controls.Add(this.txtHoTenNV);
            this.panel4.Controls.Add(this.txtMaNV);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(13, 558);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 173);
            this.panel4.TabIndex = 17;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(169, 101);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(376, 24);
            this.cbGioiTinh.TabIndex = 8;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(169, 63);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(376, 22);
            this.txtHoTenNV.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(169, 23);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(376, 22);
            this.txtMaNV.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
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
            // grNV
            // 
            this.grNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.GioiTinh,
            this.DiaChi,
            this.ChucVu,
            this.KieuCV});
            this.grNV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grNV.Location = new System.Drawing.Point(12, 190);
            this.grNV.Name = "grNV";
            this.grNV.RowTemplate.Height = 24;
            this.grNV.Size = new System.Drawing.Size(1234, 324);
            this.grNV.TabIndex = 16;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ tên nhân viên";
            this.HoTenNV.Name = "HoTenNV";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // KieuCV
            // 
            this.KieuCV.DataPropertyName = "KieuCV";
            this.KieuCV.HeaderText = "Kiểu công việc";
            this.KieuCV.Name = "KieuCV";
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
            this.label1.Location = new System.Drawing.Point(405, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 769);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStaff";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.fStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grNV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXOA;
        private System.Windows.Forms.Button btLAMMOI;
        private System.Windows.Forms.Button btKHOITAO;
        private System.Windows.Forms.Button btCAPNHAT;
        private System.Windows.Forms.Button btTHEM;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbKieuCV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.Button btQL;
        private System.Windows.Forms.Button btTIMKIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KieuCV;
    }
}
