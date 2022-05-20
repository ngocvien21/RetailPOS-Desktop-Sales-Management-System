using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace fLogin
{
    public partial class fBilll : Form
    {
        SqlConnection connection; //kết nối cho hoá đơn bán hàng
        SqlCommand command; //dùng cho HDBH
        SqlConnection con; // Kết nối cho chi tiết HDBH
        SqlCommand com; //Dùng cho CT HDBH
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter(); //dùng cho HDBH
        DataTable tableHD = new DataTable(); //dùng cho HDBH
        SqlDataAdapter da = new SqlDataAdapter();//Dùng cho CT HDBH
        DataTable tableCTHD = new DataTable(); //Dùng cho CT HDBH
        public fBilll()
        {
            InitializeComponent();
        }
        #region Load database lên datagripview
        void loaddata() //Dùng cho HDBH
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from HOADONBANHANG ";
            adapter.SelectCommand = command;
            tableHD.Clear();
            adapter.Fill(tableHD);
            grHD.DataSource = tableHD;
        }
        void Ketnoicsdl() //Dùng cho CT HDBH
        {
            com = con.CreateCommand();
            com.CommandText = "Select * from CHITIET_HOADONBANHANG";
            da.SelectCommand = com;
            tableCTHD.Clear();
            da.Fill(tableCTHD);
            grChiTietHD.DataSource = tableCTHD;

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grChiTietHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fBilll_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'QuanLyBanHangThoiTrangDataSet.HOADONBANHANG' table. You can move, or remove it, as needed.
// TODO: This line of code loads data into the 'QuanLyBanHangThoiTrangDataSet.TKTenHH' table. You can move, or remove it, as needed.
            
 //Load data lên
            txtMaHDBH.Enabled = false;
            txtMaHD.Enabled = false;
            connection = new SqlConnection(str);
            connection.Open();
            con = new SqlConnection(str);
            con.Open();
            loaddata();
            Ketnoicsdl();
            this.grChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grChiTietHD.Columns["MaHDBH"].HeaderText = "Mã hoá đơn bán hàng";
            grChiTietHD.Columns["MaHH"].HeaderText = "Mã hàng hoá";
            grChiTietHD.Columns["SoLuongBan"].HeaderText = "Số lượng";
            grChiTietHD.Columns["ThanhTien"].HeaderText = "Thành tiền";
            binding1();
            binding();
            connection.Close();
            con.Close();          
        }
        void binding1() // Đổ data vào textbox của hoá đơn bán hàng
        {

            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", grHD.DataSource, "MaHDBH");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", grHD.DataSource, "MaNV");
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", grHD.DataSource, "MaKH");
            dtNgayBan.DataBindings.Clear();
            dtNgayBan.DataBindings.Add("Text", grHD.DataSource, "NgayBan");
            txtGiamGia.DataBindings.Clear();
            txtGiamGia.DataBindings.Add("Text", grHD.DataSource, "GiamGia");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", grHD.DataSource, "TongTien");
            cbHinhThucThanhToan.DataBindings.Clear();
            cbHinhThucThanhToan.DataBindings.Add("Text", grHD.DataSource, "HinhThucThanhToan");
        }
        void binding() // Đổ data vào textbox của chi tiết hoá đơn bán hàng
        {

            txtMaHDBH.DataBindings.Clear();
            txtMaHDBH.DataBindings.Add("Text", grChiTietHD.DataSource, "MaHDBH");
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", grChiTietHD.DataSource, "MaHH");
            txtSoLuongBan.DataBindings.Clear();
            txtSoLuongBan.DataBindings.Add("Text", grChiTietHD.DataSource, "SoLuongBan");
            txtThanhTien.DataBindings.Clear();
            txtThanhTien.DataBindings.Add("Text", grChiTietHD.DataSource, "ThanhTien");
        }

        #endregion
        #region Tìm kiếm
        private void btTIM_Click(object sender, EventArgs e) //Tìm kiếm trong bảng hoá đơn bán hàng bẵng mã HDBH
        {
            if (!txtTIM.Text.Equals(""))
            {
                command = connection.CreateCommand();
                command.CommandText = "Exec spTimHD '" + txtTIM.Text + "'";
                adapter.SelectCommand = command;
                tableHD.Clear();
                adapter.Fill(tableHD);
                grHD.DataSource = tableHD;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền mã hoá đơn!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }


        private void btTIMKIEMCTHD_Click(object sender, EventArgs e) // Tìm kiếm trong bảng chi tiết hoá đơn bằng mã HDBH
        {
            if (!txtTIMKIEMCTHD.Text.Equals(""))
            {
            com = con.CreateCommand();
            com.CommandText = "Exec spTimChiTietHD '" + txtTIMKIEMCTHD.Text + "'";
            da.SelectCommand = com;
            tableCTHD.Clear();
            da.Fill(tableCTHD);
            grChiTietHD.DataSource = tableCTHD;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền mã hoá đơn bán hàng!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Quay lại
        private void btQL_Click(object sender, EventArgs e)//Hoá đơn bán hàng
        {
            fMenu f = new fMenu();
            this.Hide();
            f.ShowDialog();
            this.Hide();
        }

        private void btQLCTHD_Click(object sender, EventArgs e)//Chi tiết hoá đơn bán hàng
        {
            fMenu f = new fMenu();
            this.Hide();
            f.ShowDialog();
            this.Hide();
        }

        private void btQLofBC_Click(object sender, EventArgs e)//Hoá đơn bán hàng
        {
            fMenu f = new fMenu();
            this.Hide();
            f.ShowDialog();
            this.Hide();
        }
        #endregion
        #region Thêm
        private void btTHEM_Click(object sender, EventArgs e) //Thêm HDBH mới chỉ thêm mã nhân viên, ngày bán, mã KH, giảm giá, và hình thức thanh toán
        {
            txtMaHD.Focus();
            if (this.txtMaNV.TextLength == 0 || this.txtMaKH.TextLength == 0 || this.dtNgayBan.Value == null || this.txtGiamGia.TextLength == 0 || this.cbHinhThucThanhToan.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                //Tạo mã HDBH tự động
                int count = 0;
                count = grHD.Rows.Count;// đếm tất cả các hàng trong datagridview có tên grHD rồi đem đi gán cho count
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(grHD.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 6)));//loại bỏ chữ kí tự HDBH00
                if (chuoi2 + 1 < 10)
                    txtMaHD.Text = "HDBH000" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 > 10)
                    txtMaHD.Text = "HDBH00" + (chuoi2 + 1).ToString();
                try
                {

                    connection.Open();
                    string sql = @"Insert into HOADONBANHANG(MaHDBH, MaNV, MaKH, NgayBan, GiamGia, HinhThucThanhToan) values 
                   (N'" + txtMaHD.Text + "', N'" + txtMaNV.Text + "',N'" + txtMaKH.Text + "' ,'" + Convert.ToDateTime(dtNgayBan.Value).ToString("yyyy-MM-dd") + "','" + txtGiamGia.Text + "',N'" + cbHinhThucThanhToan.Text + "')";
                    SqlCommand tt = new SqlCommand(sql, connection);
                    tt.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHD.Focus();
                }
            }
        }

        private void btTHEMCTHD_Click(object sender, EventArgs e) //Thêm chi tiết HDBH(chỉ thêm Mã HH và số lượng bán)
        {
            txtMaHDBH.Focus();
            if (this.txtMaHH.TextLength == 0 || this.txtSoLuongBan.TextLength == 0)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                int count = 0;
                count = grChiTietHD.Rows.Count;// đếm tất cả các hàng trong datagridview có tên grChiTietHD rồi đem đi gán cho count
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(grChiTietHD.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 6)));//loại bỏ chữ kí tự HDBH00
                if (chuoi2 + 1 < 10)
                    txtMaHDBH.Text = "HDBH000" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 > 10)
                    txtMaHDBH.Text = "HDBH00" + (chuoi2 + 1).ToString();
                try
                {
                    con.Open();
                    string sql = @"Insert into CHITIET_HOADONBANHANG(MaHDBH, MaHH, SoLuongBan, ThanhTien) values 
                   (N'" + txtMaHDBH.Text + "', N'" + txtMaHH.Text + "', N'" + txtSoLuongBan.Text + "', N'" + txtThanhTien.Text + "')";
                    SqlCommand tt = new SqlCommand(sql, con);
                    tt.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaKH.Focus();
                }
            }
        }
        #endregion
        #region Cập nhật
        private void btSUACTHD_Click(object sender, EventArgs e) // Cập nhật lại tất cả trừ mã HDBH trong chi tiết HDBH
        {
            txtMaHDBH.Focus();
            if (this.txtMaHH.TextLength == 0 || this.txtSoLuongBan.TextLength == 0)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    con.Open();
                    com = con.CreateCommand();
                    com.CommandText = "Update CHITIET_HOADONBANHANG set MaHH = '" + txtMaHH.Text + "', SoLuongBan = '" + txtSoLuongBan.Text + "', ThanhTien = " + txtThanhTien.Text + " where MaHDBH = '" + txtMaHDBH.Text + "' and MaHH = '" + txtMaHH.Text + "'";
                    com.ExecuteNonQuery();
                    Ketnoicsdl();
                    MessageBox.Show("Bạn đã sửa dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHDBH.Focus();
                }
            }
        }

        private void btCAPNHAT_Click(object sender, EventArgs e) //Được phép cập nhật hết ngoại trừ mã HDBH trong bảng hoá đơn bán hàng
        {
            txtMaHD.Focus();
            if (this.txtMaNV.TextLength == 0 || this.txtMaKH.TextLength == 0 || this.dtNgayBan.Value == null || this.txtGiamGia.TextLength == 0
                 || this.cbHinhThucThanhToan.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "Update HOADONBANHANG set MaNV = N'" + txtMaNV.Text + "', MaKH = N'" + txtMaKH.Text + "', NgayBan = N'" + Convert.ToDateTime(dtNgayBan.Text).ToString("yyyy-MM-dd") + "', GiamGia = '" + txtGiamGia.Text + "', HinhThucThanhToan = N'" + cbHinhThucThanhToan.Text + "' where MaHDBH = '" + txtMaHD.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    connection.Close();
                    MessageBox.Show("Bạn đã sửa dữ liệu thành công!", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHH.Focus();
                }
            }
        }
        #endregion
        #region Khởi tạo
        private void btKHOITAO_Click(object sender, EventArgs e)
        {
            loaddata();
        } //Khởi tạo bảng hoá đơn bán hàng

        private void btKHOITAOCTHD_Click(object sender, EventArgs e)
        {
            Ketnoicsdl();
        } //Khởi tạo bảng chi tiết hoá đơn bán hàng
        #endregion
        #region Làm mới
        private void btLAMMOICTHD_Click(object sender, EventArgs e)
        {
            txtMaHDBH.Text = "";
            txtMaHH.Text = "";
            txtSoLuongBan.Text = "";
            txtThanhTien.Text = "";
        } //Làm mới bảng chi tiết hoá đơn bán hàng

        private void btLAMMOI_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtMaKH.Text = "";
            dtNgayBan.Text = "";
            txtGiamGia.Text = "";
            txtTongTien.Text = "";
            cbHinhThucThanhToan.Text = "";
        } //Làm mới bảng hoá đơn bán hàng
        #endregion
        #region Xoá
        private void btXOA_Click(object sender, EventArgs e) //Hoá đơn bán hàng
        {
            DialogResult lenh = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (lenh == DialogResult.OK)
            {
                try
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "Exec spDeHDBH '" + txtMaHD.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    connection.Close();
                    MessageBox.Show("Bạn đã xoá dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btXOACTHD_Click(object sender, EventArgs e)//Xoá chi tiết hoá đơn
        {
            DialogResult lenh = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (lenh == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    com = con.CreateCommand();
                    com.CommandText = "Exec spDeCTHD '" + txtMaHDBH.Text + "', '" + txtMaHH.Text + "'";
                    com.Parameters.AddWithValue("MaHDBH", txtMaHDBH.Text);
                    com.Parameters.AddWithValue("MaHH", txtMaHH.Text);
                    com.ExecuteNonQuery();
                    Ketnoicsdl();
                    con.Close();
                    MessageBox.Show("Bạn đã xoá dữ liệu thành công!", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
       
        
    }
    }

