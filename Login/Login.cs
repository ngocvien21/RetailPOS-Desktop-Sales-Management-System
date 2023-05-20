using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class Form1 : Form
    {

             
        public Form1()
        {
            InitializeComponent();
        }

        #region Đăng nhập
        private void btDN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where TenDangNhap=N'" + txtTenDangNhap.Text + "' and MatKhau=N'" + txtMatKhau.Text + "'",con);
            DataTable dt = new DataTable(); // tạo một datatable ới đặt tên là dt
            da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    //Đăng nhâp thành công
                    fMenu f = new fMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString()); //so sánh dữ liệu của dt
                    this.Hide();
                    f.ShowDialog(); //hiển thị form menu đồng thời đóng form đăng nhập
                    this.Show();
                }
                else
                {
                   //Đăng nhập thất bại
                 MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close(); 
            }
            
      
        #endregion 
    
public  string Sql { get; set; }
#region Hiển thị mật khẩu
private void cbHTMK_CheckedChanged_1(object sender, EventArgs e)
{
    {
        if (cbHTMK.Checked)
        {
            txtMatKhau.UseSystemPasswordChar = false;
        }
        else
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
    }
}
#endregion
        #region Thoát
private void btTHOAT_Click_1(object sender, EventArgs e)
{
    if (MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
    {
        Application.Exit();
    }
}
        #endregion

private void fLogin_Load(object sender, EventArgs e)
{

}

public static string TenHienThi { get; set; }

public static string TenDangNhap { get; set; }

public static string MatKhau { get; set; }
    }
}
