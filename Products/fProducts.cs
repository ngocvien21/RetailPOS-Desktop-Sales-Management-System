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
    public partial class fProducts : Form
    {
        public fProducts()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        string st = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        private DataTable table = new DataTable("HANGHOA");
        private void label3_Click(object sender, EventArgs e)
        {

        }
        #region load data lên datagripview
        private void fProducts_Load(object sender, EventArgs e)
        {
            txtMaHH.Enabled = false;
            con = new SqlConnection(st);
            con.Open();
            Ketnoicsdl();
            binding();
            con.Close();
        }
        void Ketnoicsdl()
        {
            com = con.CreateCommand();
            com.CommandText = "Select * from HANGHOA";
            da.SelectCommand = com;
            table.Clear();
            da.Fill(table);
            grHH.DataSource = table;
        }
#endregion
        #region Binding
        private void binding()
        {
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", grHH.DataSource, "MaHH", true, DataSourceUpdateMode.Never);

            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("Text", grHH.DataSource, "TenHH", true, DataSourceUpdateMode.Never);

            txtXuatXu.DataBindings.Clear();
            txtXuatXu.DataBindings.Add("Text", grHH.DataSource, "XuatXu", true, DataSourceUpdateMode.Never);

            txtSoLuongHHTon.DataBindings.Clear();
            txtSoLuongHHTon.DataBindings.Add("Text", grHH.DataSource, "SoLuongHHTon", true, DataSourceUpdateMode.Never);

            txtDonGiaNhap.DataBindings.Clear();
            txtDonGiaNhap.DataBindings.Add("Text", grHH.DataSource, "DonGiaNhap", true, DataSourceUpdateMode.Never);

            txtDonGiaBan.DataBindings.Clear();
            txtDonGiaBan.DataBindings.Add("Text", grHH.DataSource, "DonGiaBan", true, DataSourceUpdateMode.Never);

            txtDanhMuc.DataBindings.Clear();
            txtDanhMuc.DataBindings.Add("Text", grHH.DataSource, "DanhMuc", true, DataSourceUpdateMode.Never);
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
            if (!txtTIMKIEM.Text.Equals(""))
            {
                com = con.CreateCommand();
                com.CommandText = "Exec spTIMTenHH N'" + txtTIMKIEM.Text + "'";
                da.SelectCommand = com;
                table.Clear();
                da.Fill(table);
                grHH.DataSource = table;
            }
            else
            {
                MessageBox.Show("Bạn chưa điền tên hàng hoá!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Thêm
        private void btTHEM_Click(object sender, EventArgs e)
        {
            txtMaHH.Focus();
            if (this.txtTenHH.TextLength == 0 || this.txtXuatXu.Text == null || this.txtSoLuongHHTon.TextLength == 0 || this.txtDonGiaNhap.TextLength == 0
                 || this.txtDonGiaBan.TextLength == 0 || this.txtDanhMuc.TextLength == 0)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                //Cập nhật tự động mã hàng hoá
                int count = 0;
                count = grHH.Rows.Count;// đếm tất cả các hàng trong grHH rồi đem đi gán cho count
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(grHH.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));//loại bỏ chữ kí tự HH0
                if (chuoi2 +1 <10)
                    txtMaHH.Text = "HH00" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 > 10)
                txtMaHH.Text = "HH0" + (chuoi2 + 1).ToString();
                try
                {
                    con.Open();
                    string sql = @"Insert into HANGHOA(MaHH, TenHH, XuatXu, SoLuongHHTon, DonGiaNhap , DonGiaBan, DanhMuc) values              
                   (N'" + txtMaHH.Text + "', N'" + txtTenHH.Text + "', N'" + txtXuatXu.Text + "', N'" + txtSoLuongHHTon.Text + "', N'" + txtDonGiaNhap.Text + "', N'" + txtDonGiaBan.Text + "', N'" + txtDanhMuc.Text + "')";
                    SqlCommand tt = new SqlCommand(sql, con);
                    tt.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHH.Focus();
                }
            }
        }
        #endregion
        #region Cập nhật
        private void btCAPNHAT_Click(object sender, EventArgs e)
        {
            txtMaHH.Focus();
            if (this.txtTenHH.TextLength == 0 || this.txtXuatXu.Text == null || this.txtSoLuongHHTon.TextLength == 0 || this.txtDonGiaNhap.TextLength == 0
                 || this.txtDonGiaBan.TextLength == 0 || this.txtDanhMuc.TextLength == 0)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    con.Open();
                    com = con.CreateCommand();
                    com.CommandText = "Update HANGHOA Set TenHH = @TenHH, XuatXu = @XuatXu, SoLuongHHTon = @SoLuongHHTon, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, DanhMuc = @DanhMuc Where MaHH = @MaHH";
                    com.Parameters.AddWithValue("MaHH", txtMaHH.Text);
                    com.Parameters.AddWithValue("TenHH", txtTenHH.Text);
                    com.Parameters.AddWithValue("XuatXu", txtXuatXu.Text);
                    com.Parameters.AddWithValue("SoLuongHHTon", txtSoLuongHHTon.Text);
                    com.Parameters.AddWithValue("DonGiaNhap", txtDonGiaNhap.Text);
                    com.Parameters.AddWithValue("DonGiaBan", txtDonGiaBan.Text);
                    com.Parameters.AddWithValue("DanhMuc", txtDanhMuc.Text);
                    com.ExecuteNonQuery();
                    Ketnoicsdl();
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
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
            Ketnoicsdl();
        }
        #endregion
        #region Làm mới
        private void btLAMMOI_Click(object sender, EventArgs e)
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtXuatXu.Text = "";
            txtSoLuongHHTon.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtDanhMuc.Text = "";
        }
        #endregion
        #region Xoá
        private void btXOA_Click(object sender, EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (lenh == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    com = con.CreateCommand();
                    com.CommandText = "Exec spDeHH '" + txtMaHH.Text + "'";
                    com.Parameters.AddWithValue("MaNV", txtMaHH.Text);
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
    }
}
