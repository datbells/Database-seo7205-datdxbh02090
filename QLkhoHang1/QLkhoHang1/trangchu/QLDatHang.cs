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
    public partial class QLDatHang : Form
    {
        public QLDatHang()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO PurchaseHistory VALUES (@purchaseID,@customerCode,@productCode,@purchaseDate,@quantity,@status)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("purchaseID", txtid.Text);
            cmd.Parameters.AddWithValue("customerCode", txtMaxKH.Text);
            cmd.Parameters.AddWithValue("productCode", txtMaSP.Text);
            cmd.Parameters.AddWithValue("purchaseDate", Convert.ToDateTime(txtdate.Text).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("quantity", txtSL.Text);
            cmd.Parameters.AddWithValue("status", txtStatus.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM PurchaseHistory";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            qlDonHang.DataSource = dt;


        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE PurchaseHistory SET customerCode = @customerCode, productCode = @productCode, purchaseDate = @purchaseDate, quantity = @quantity, status= @status WHERE purchaseID = @purchaseID";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("purchaseID", txtid.Text);
            cmd.Parameters.AddWithValue("customerCode", txtMaxKH.Text);
            cmd.Parameters.AddWithValue("productCode", txtMaSP.Text);
            cmd.Parameters.AddWithValue("purchaseDate", Convert.ToDateTime(txtdate.Text).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("quantity", txtSL.Text);
            cmd.Parameters.AddWithValue("status", txtStatus.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM PurchaseHistory WHERE purchaseID = @purchaseID";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("purchaseID", txtid.Text);
            cmd.Parameters.AddWithValue("customerCode", txtMaxKH.Text);
            cmd.Parameters.AddWithValue("productCode", txtMaSP.Text);
            cmd.Parameters.AddWithValue("purchaseDate", Convert.ToDateTime(txtdate.Text).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("quantity", txtSL.Text);
            cmd.Parameters.AddWithValue("status", txtStatus.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT *  FROM PurchaseHistory WHERE purchaseID = @purchaseID";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("purchaseID", txtTimKiem.Text);
            cmd.Parameters.AddWithValue("customerCode", txtMaxKH.Text);
            cmd.Parameters.AddWithValue("productCode", txtMaSP.Text);
            cmd.Parameters.AddWithValue("purchaseDate", txtdate.Text);
            cmd.Parameters.AddWithValue("quantity", txtSL.Text);
            cmd.Parameters.AddWithValue("status", txtStatus.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            qlDonHang.DataSource = dt;
        }

        private void qlDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLDatHang_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLkhohang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void QLDatHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
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
