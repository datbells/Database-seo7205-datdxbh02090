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
    public partial class frmDangNhap : Form
    {
        SqlConnection conn = null;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(conn == null)
            {
                conn = new SqlConnection(@"Data Source=XUANDAT;Initial Catalog=QLkhohang;Integrated Security=True");
            }
            
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM NguoiDung WHERE TaiKhoan = '" + tk + "' AND MatKhau = '" + mk + "'";
            cmd.Connection = conn;

            SqlDataReader data = cmd.ExecuteReader();

            if(data.Read() == true)
            {
                Trangchu f = new Trangchu();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }

            data.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
