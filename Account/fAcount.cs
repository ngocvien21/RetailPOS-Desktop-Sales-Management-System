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
    public partial class fAcount : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public fAcount()
        {
            InitializeComponent();
        }
        #region Load database lên datagripview
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from TAIKHOAN ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            grQLTK.DataSource = table;
        }
        private void fAcount_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            binding();
            connection.Close();
        }
        #endregion
        #region Binding
        private void binding()
        {
            txtTenHienThi.DataBindings.Clear();
            txtTenHienThi.DataBindings.Add("Text", grQLTK.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", grQLTK.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never);

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", grQLTK.DataSource, "MatKhau", true, DataSourceUpdateMode.Never);
        }
        #endregion
        #region Làm mới
        private void btLAMMOI_Click(object sender, System.EventArgs e)
        {
            txtTenHienThi.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
        #endregion
        #region Thêm
        private void btTHEM_Click(object sender, System.EventArgs e)
        {
            {
                txtTenHienThi.Focus();
                if (this.txtTenHienThi.TextLength == 0 || this.txtTenDangNhap.TextLength == 0 || this.txtMatKhau.TextLength == 0)
                {
                    MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin ", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {                    
                    try
                    {
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "Insert into TAIKHOAN(TenHienThi, TenDangNhap, MatKhau) values(N'" + txtTenHienThi.Text + "',N'" + txtTenDangNhap.Text + "', N'" + txtMatKhau.Text + "')";
                        command.ExecuteNonQuery();
                        loaddata();
                        MessageBox.Show("Bạn đã thêm dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenHienThi.Focus();
                    }
                }
            }
        }
        #endregion
        #region Cập nhật
        private void btCAPNHAT_Click(object sender, System.EventArgs e)
        {
            {
                txtTenHienThi.Focus();
                if (this.txtTenDangNhap.TextLength == 0 || this.txtMatKhau.TextLength == 0)
                {
                    MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin ", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "Update TAIKHOAN set TenDangNhap = N'" + txtTenDangNhap.Text + "', MatKhau = N'" + txtMatKhau.Text + "' where TenHienThi = N'" + txtTenHienThi.Text + "'";
                        command.ExecuteNonQuery();
                        loaddata();
                        MessageBox.Show("Bạn đã sửa dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenHienThi.Focus();
                    }
                }
            }
        }
        #endregion
        #region Xoá
        private void btXOA_Click(object sender, System.EventArgs e)
        {
            DialogResult lenh = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (lenh == DialogResult.OK)
            {
                try
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "Delete from TAIKHOAN where TenHienThi = N'" + txtTenHienThi.Text + "'";
                    command.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Bạn đã xoá dữ liệu thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        #endregion
        #region Quay lại
        private void btQL_Click(object sender, System.EventArgs e)
        {
            fMenu f = new fMenu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
        #region Tìm kiếm
        private void btTIMKIEM_Click(object sender, System.EventArgs e)
        {
            if (!txtTIMKIEM.Text.Equals(""))
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "Exec spTimTK N'" + txtTIMKIEM.Text + "'";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                grQLTK.DataSource = table;
                connection.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập!");
            }
        }
        #endregion
        #region Khởi tạo
        private void btKHOITAO_Click(object sender, System.EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from TAIKHOAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
        }
        #endregion
    }
}
