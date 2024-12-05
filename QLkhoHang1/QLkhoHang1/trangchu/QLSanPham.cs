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
    public partial class QLSanPham : Form
    {
        public QLSanPham()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO Product VALUES (@code,@name,@quantity,@price)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("code", txtCode.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("quantity", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("price", txtPrice.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE Product SET name = @name, quantity = @quantity, price = @price WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("code", txtCode.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("quantity", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("price", txtPrice.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM Product WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("code", txtCode.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("quantity", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("price", txtPrice.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Product";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            danhsachSP.DataSource = dt;

        }


        private void QLSanPham_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLkhohang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void QLSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT *  FROM Product WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("code", txtTimKiem.Text);
            cmd.Parameters.AddWithValue("name", txtTen.Text);
            cmd.Parameters.AddWithValue("quantity", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("price", txtPrice.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            danhsachSP.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trangchu f = new Trangchu();
            f.Show();
            this.Hide();


        }
    }
}
