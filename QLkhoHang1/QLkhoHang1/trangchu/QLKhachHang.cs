using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace trangchu
{
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void bthThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO Customer VALUES (@code,@name,@phoneNumber,@address)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("code", txtCode.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("phoneNumber", txtSdt.Text);
            cmd.Parameters.AddWithValue("address", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            HienThi();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE Customer SET name = @name, phoneNumber = @phoneNumber, address = @address WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("code", txtCode.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("phoneNumber", txtSdt.Text);
            cmd.Parameters.AddWithValue("address", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM Customer WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("code", txtCode.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("phoneNumber", txtSdt.Text);
            cmd.Parameters.AddWithValue("address", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Customer";
            SqlCommand cmd = new SqlCommand(sqlSELECT,con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsKhachHang.DataSource = dt;

        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
             string conString = ConfigurationManager.ConnectionStrings["QLkhohang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void QLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT *  FROM Customer WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("code", txtTimKiem.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("phoneNumber", txtSdt.Text);
            cmd.Parameters.AddWithValue("address", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsKhachHang.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trangchu f = new Trangchu();
            f.Show();
            this.Hide();
        }
    }
}
