namespace fLogin
{
    partial class fProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProducts));
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
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.txtSoLuongHHTon = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grHH = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHHTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grHH)).BeginInit();
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
            this.panel1.Controls.Add(this.grHH);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 757);
            this.panel1.TabIndex = 1;
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
            this.btTIMKIEM.Size = new System.Drawing.Size(144, 43);
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
            this.panel5.Controls.Add(this.txtDanhMuc);
            this.panel5.Controls.Add(this.txtDonGiaNhap);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtDonGiaBan);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(584, 558);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 173);
            this.panel5.TabIndex = 18;
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Location = new System.Drawing.Point(157, 101);
            this.txtDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(376, 22);
            this.txtDanhMuc.TabIndex = 18;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(157, 23);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(376, 22);
            this.txtDonGiaNhap.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Đơn giá nhập";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(157, 62);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(376, 22);
            this.txtDonGiaBan.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Đơn giá bán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Danh mục";
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
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtXuatXu);
            this.panel4.Controls.Add(this.txtSoLuongHHTon);
            this.panel4.Controls.Add(this.txtTenHH);
            this.panel4.Controls.Add(this.txtMaHH);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng tồn";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(169, 101);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(4);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(376, 22);
            this.txtXuatXu.TabIndex = 10;
            // 
            // txtSoLuongHHTon
            // 
            this.txtSoLuongHHTon.Location = new System.Drawing.Point(169, 140);
            this.txtSoLuongHHTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongHHTon.Name = "txtSoLuongHHTon";
            this.txtSoLuongHHTon.Size = new System.Drawing.Size(376, 22);
            this.txtSoLuongHHTon.TabIndex = 9;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(169, 63);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(376, 22);
            this.txtTenHH.TabIndex = 7;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(169, 23);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(376, 22);
            this.txtMaHH.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Xuất xứ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên hàng hoá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hàng hoá";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // grHH
            // 
            this.grHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grHH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.XuatXu,
            this.SoLuongHHTon,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.DanhMuc});
            this.grHH.Location = new System.Drawing.Point(12, 190);
            this.grHH.Name = "grHH";
            this.grHH.RowTemplate.Height = 24;
            this.grHH.Size = new System.Drawing.Size(1234, 324);
            this.grHH.TabIndex = 16;
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã hàng hoá";
            this.MaHH.Name = "MaHH";
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng hoá";
            this.TenHH.Name = "TenHH";
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.Name = "XuatXu";
            // 
            // SoLuongHHTon
            // 
            this.SoLuongHHTon.DataPropertyName = "SoLuongHHTon";
            this.SoLuongHHTon.HeaderText = "Số lượng hàng hoá tồn";
            this.SoLuongHHTon.Name = "SoLuongHHTon";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // DanhMuc
            // 
            this.DanhMuc.DataPropertyName = "DanhMuc";
            this.DanhMuc.HeaderText = "Danh mục";
            this.DanhMuc.Name = "DanhMuc";
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
            this.label1.Size = new System.Drawing.Size(351, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN HÀNG HOÁ";
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fProducts";
            this.Text = "HÀNG HOÁ";
            this.Load += new System.EventHandler(this.fProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grHH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btQL;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btXOA;
        private System.Windows.Forms.Button btLAMMOI;
        private System.Windows.Forms.Button btKHOITAO;
        private System.Windows.Forms.Button btCAPNHAT;
        private System.Windows.Forms.Button btTHEM;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grHH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHHTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.TextBox txtSoLuongHHTon;
        private System.Windows.Forms.Button btTIMKIEM;
        private System.Windows.Forms.TextBox txtDanhMuc;
    }
}
