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
    public partial class fCustomers : Form
    {
        public fCustomers()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand com;
        string st = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        private DataTable table = new DataTable("KHACHHANG");
        #region load data lên datagripview
        private void fCustomers_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            con = new SqlConnection(st);
            con.Open();
            Ketnoicsdl();
            binding();
            con.Close();
        }
        void Ketnoicsdl()
        {
            com = con.CreateCommand();
            com.CommandText = "Select * from KHACHHANG";
            da.SelectCommand = com;
            table.Clear();
            da.Fill(table);
            grKH.DataSource = table;
        }
        #endregion
        #region Binding
        private void binding()
        {
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", grKH.DataSource, "MaKH", true, DataSourceUpdateMode.Never);
          
            txtHoTenKH.DataBindings.Clear();
            txtHoTenKH.DataBindings.Add("Text", grKH.DataSource, "HoTenKH", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", grKH.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);

            dtNgaySinh.DataBindings.Clear();
            dtNgaySinh.DataBindings.Add("Text", grKH.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never);

            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", grKH.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);

            txtDiemThanThiet.DataBindings.Clear();
            txtDiemThanThiet.DataBindings.Add("Text", grKH.DataSource, "DiemThanThiet", true, DataSourceUpdateMode.Never);

            txtSDTKH.DataBindings.Clear();
            txtSDTKH.DataBindings.Add("Text", grKH.DataSource, "SDTKH", true, DataSourceUpdateMode.Never);


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
                com.CommandText = "Exec spTimTenKH N'" + txtTIMKIEM.Text + "'";
                da.SelectCommand = com;
                table.Clear();
                da.Fill(table);
                grKH.DataSource = table;
            }
            
            else
            {
                MessageBox.Show("Bạn chưa điền khách hàng cần tìm!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        
        #endregion
        #region Thêm
        private void btTHEM_Click(object sender, EventArgs e)
        {
            if (this.txtHoTenKH.TextLength == 0 || this.txtDiaChi.Text == null || this.dtNgaySinh.Value == null || this.cbGioiTinh.Text == null
                 || this.txtDiemThanThiet.TextLength == 0 || this.txtSDTKH.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            { 
                //Tạo hoá đơn mã tự động
            int count = 2;
            count = grKH.Rows.Count;// đếm tất cả các hàng trong grKH rồi đem đi gán cho count
            string chuoi ="";
            int chuoi2 = 0;
            chuoi = Convert.ToString(grKH.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0,3)));//loại bỏ chữ kí tự KH0
            if (chuoi2 + 1 < 10)
                txtMaKH.Text = "KH00" + (chuoi2 + 1).ToString();
            else if (chuoi2 + 1 > 10)
                txtMaKH.Text = "KH0" + (chuoi2 + 1).ToString();
                try
                {
                    con.Open();
                    string sql = @"Insert into KHACHHANG(MaKH, HoTenKH, DiaChi, NgaySinh, GioiTinh , DiemThanThiet, SDTKH) values              
                   (N'" + txtMaKH.Text + "', N'" + txtHoTenKH.Text + "', N'" + txtDiaChi.Text + "', N'" + Convert.ToDateTime(dtNgaySinh.Value).ToString("yyyy-MM-dd") + "',N'" + cbGioiTinh.Text + "','" + txtDiemThanThiet.Text + "','" + txtSDTKH.Text + "')";
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
        private void btCAPNHAT_Click(object sender, EventArgs e)
        {
            txtMaKH.Focus();
            if (this.txtHoTenKH.TextLength == 0 || this.txtDiaChi.Text == null || this.dtNgaySinh.Value == null || this.cbGioiTinh.Text == null
                 || this.txtDiemThanThiet.TextLength == 0 || this.txtSDTKH.Text == null)
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = ("UPDATE KHACHHANG SET HoTenKH =N'" + txtHoTenKH.Text + "', DiaChi =N'" + txtDiaChi.Text + "', NgaySinh=N'" + Convert.ToDateTime(dtNgaySinh.Value).ToString("yyyy-MM-dd") + "', GioiTinh=N'" + cbGioiTinh.Text + "', DiemThanThiet='" + txtDiemThanThiet.Text + "', SDTKH='" + txtSDTKH.Text + "' WHERE MaKH='" + txtMaKH.Text + "'");
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
        #region Khởi tạo
        private void btKHOITAO_Click(object sender, EventArgs e)
        {
            Ketnoicsdl();
        }
        #endregion
        #region Làm mới
        private void btLAMMOI_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChi.Text = "";
            dtNgaySinh.Text = "";
            cbGioiTinh.Text = "";
            txtDiemThanThiet.Text = "";
            txtSDTKH.Text = "";

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
                    com.CommandText = "Delete from KHACHHANG where MaKH = '" + txtMaKH.Text + "'";
                    com.ExecuteNonQuery();
                    Ketnoicsdl();
                    MessageBox.Show("Bạn đã xoá dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

            