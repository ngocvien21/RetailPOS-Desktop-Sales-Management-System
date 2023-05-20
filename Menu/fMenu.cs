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
    public partial class fMenu : Form
    {
        string TenHienThi = "", TenDangNhap = "", MatKhau = ""; //dữ liệu nhập vào từ fLogin
        string ketnoi = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyBanHangThoiTrang;Integrated Security=True";
                 
        public fMenu(string TenHienThi, string TenDangNhap, string MatKhau) //khai báo biến mới dạng chuỗi
        {
            InitializeComponent();
            this.TenHienThi = TenHienThi; // gán biến mới bằng dữ liệu nhập từ fLogin
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
        }
        public fMenu()
        {
            InitializeComponent();
        }
        #region Show Hàng Hoá
        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProducts f = new fProducts();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
        #region Show Khách
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomers f = new fCustomers();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
        #region Show ControlTab Hoá đơn + CT hoá đơn
        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBilll f = new fBilll();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
        #region Show tạo HĐ
        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        #region Đăng xuất tài khoản khỏi Menu
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion
        #region Thoát khỏi menu
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion
        #region Show QLTK
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TenDangNhap == "Admin") //nếu TenDangNhap là Admin
            {
                fAcount f = new fAcount();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else //không phải Admin
            {
                MessageBox.Show("Không được phép!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        #endregion
        #region Show nhân viên
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TenDangNhap == "Admin")
            {
                fStaff f = new fStaff();
                this.Hide();
                f.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Không được phép!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        #endregion

        private void fMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
