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

namespace fLogin
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        string st = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        private DataTable table = new DataTable("NHANVIEN");
        #region Load database lên datagripview

        private void fStaff_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(st);
            con.Open();
            Ketnoicsdl();
            binding();
            con.Close();
        }
        void Ketnoicsdl()
        {
            com = con.CreateCommand();
            com.CommandText = "Select * from NHANVIEN";
            da.SelectCommand = com;
            table.Clear();
            da.Fill(table);
            grNV.DataSource = table;
        }
        #endregion
        #region Binding
        private void binding()
        {
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", grNV.DataSource, "MaNV", true, DataSourceUpdateMode.Never);

            txtHoTenNV.DataBindings.Clear();
            txtHoTenNV.DataBindings.Add("Text", grNV.DataSource, "HoTenNV", true, DataSourceUpdateMode.Never);

            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", grNV.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grNV.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);

            txtChucVu.DataBindings.Clear();
            txtChucVu.DataBindings.Add("Text", grNV.DataSource, "ChucVu", true, DataSourceUpdateMode.Never);

            cbKieuCV.DataBindings.Clear();
            cbKieuCV.DataBindings.Add("Text", grNV.DataSource, "KieuCV", true, DataSourceUpdateMode.Never);
        }
        #endregion
        #region Quay lại
        private void btQL_Click(object sender, EventArgs e)
        {
            fMenu f = new fMenu();
            this.Hide();
            f.ShowDialog();
            this.Hide();
        }
        #endregion
        #region Tìm kiếm
        private void btTIMKIEM_Click(object sender, EventArgs e)
        {
            timdata();
        }
        void timdata()
        {
            com = con.CreateCommand();
            if (!txtTIMKIEM.Text.Equals(""))
            {               
                com.CommandText = "Exec spTIMTenNV N'" + txtTIMKIEM.Text + "'";
                da.SelectCommand = com;
                table.Clear();
                da.Fill(table);
                grNV.DataSource = table;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền tên nhân viên!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Thêm
       
        private void btTHEM_Click(object sender, EventArgs e)
        {
            //Để trống sẽ hiện thông báo
            txtMaNV.Focus();
            if (this.txtHoTenNV.TextLength == 0 || this.cbGioiTinh.Text == null || this.txtDiaChi.TextLength == 0 || this.txtChucVu.TextLength == 0
                 || this.cbKieuCV.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                //Nếu đầy đủ thông tin
                try
                {
                    con.Open();
                    string sql = @"Insert into NHANVIEN(MaNV, HoTenNV, GioiTinh, DiaChi, ChucVu , KieuCV) values              
                   (N'" + txtMaNV.Text + "', N'" + txtHoTenNV.Text + "', N'" + cbGioiTinh.Text + "', N'" + txtDiaChi.Text + "',N'" + txtChucVu.Text + "',N'" + cbKieuCV.Text + "')";
                    SqlCommand tt = new SqlCommand(sql, con);
                    tt.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaNV.Focus();
                }
            }
        }
        #endregion
        #region Cập nhật
        private void btCAPNHAT_Click(object sender, EventArgs e)
        {
            //Để trống textbox sẽ hiện thông báo
            if (this.txtMaNV.TextLength == 0 || this.txtHoTenNV.TextLength == 0
        || this.cbGioiTinh.Text == null || this.txtDiaChi.TextLength == 0 || this.txtChucVu.TextLength == 0
                 || this.cbKieuCV.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                //Đầy đủ thông tin
                try
                {
                    con.Open();
                    com = con.CreateCommand();
                    com.CommandText = "Update NHANVIEN Set HoTenNV = @HoTenNV,  GioiTinh = @GioiTinh, DiaChi = @DiaChi,  ChucVu = @ChucVu, KieuCV = @KieuCV Where MaNV = @MaNV";
                    com.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                    com.Parameters.AddWithValue("HoTenNV", txtHoTenNV.Text);
                    com.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
                    com.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                    com.Parameters.AddWithValue("ChucVu", txtChucVu.Text);
                    com.Parameters.AddWithValue("KieuCV", cbKieuCV.Text);
                    com.ExecuteNonQuery();
                    Ketnoicsdl();
                    con.Close();
                    MessageBox.Show("Bạn đã sửa dữ liệu thành công!", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
#endregion
        private void loaddata()
        {
            throw new NotImplementedException();
        }
 
        #region Xoá
        private void btXOA_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (lenh == DialogResult.OK)
            {
                try
                    //Xoá nhân viên
                {
                    con.Open();
                    com = con.CreateCommand();
                    com.CommandText = "Exec spDeNV '" + txtMaNV.Text + "'";
                    com.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                    com.ExecuteNonQuery();
                    Ketnoicsdl();
                    MessageBox.Show("Bạn đã xoá dữ liệu thành công!", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Khởi tạo
        private void btKHOITAO_Click(object sender, EventArgs e)
        {
            Ketnoicsdl();
        }
        #endregion
        #region Làm mới
        private void btLAMMOI_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtHoTenNV.Text = "";
            cbGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";
            cbKieuCV.Text = "";
        }
        #endregion
   
 }
}
