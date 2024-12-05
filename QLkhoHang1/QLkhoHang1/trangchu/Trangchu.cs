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

namespace trangchu
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Close();
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLKhachHang f = new QLKhachHang();
            f.Show();
            this.Hide();
        }

        private void Trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLSanPham f = new QLSanPham();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLNhanVien f = new QLNhanVien();
            f.Show();
            this.Hide();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            QLDatHang f = new QLDatHang();
            f.Show();
            this.Hide();
        }
    }
}
