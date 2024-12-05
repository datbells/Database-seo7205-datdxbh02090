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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO Employee VALUES (@code,@name,@position,@roleId,@username,@password)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("code", txtcode.Text);
            cmd.Parameters.AddWithValue("name", txttennv.Text);
            cmd.Parameters.AddWithValue("position", txtvitri.Text);
            cmd.Parameters.AddWithValue("roleId", txtquyen.Text);
            cmd.Parameters.AddWithValue("username", txttk.Text);
            cmd.Parameters.AddWithValue("password", txtmk.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QLkhohang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEdit = "UPDATE Employee SET name = @name, position = @position, roleId = @roleId, roleId = @roleId,username =@username, password=@password  WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("code", txtcode.Text);
            cmd.Parameters.AddWithValue("name", txttennv.Text);
            cmd.Parameters.AddWithValue("position", txtvitri.Text);
            cmd.Parameters.AddWithValue("roleId", txtquyen.Text);
            cmd.Parameters.AddWithValue("username", txttk.Text);
            cmd.Parameters.AddWithValue("password", txtmk.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "DELETE FROM Employee WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("code", txtcode.Text);
            cmd.Parameters.AddWithValue("name", txttennv.Text);
            cmd.Parameters.AddWithValue("position", txtvitri.Text);
            cmd.Parameters.AddWithValue("roleId", txtquyen.Text);
            cmd.Parameters.AddWithValue("username", txttk.Text);
            cmd.Parameters.AddWithValue("password", txtmk.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }


        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Employee";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            danhsachNhanVien.DataSource = dt;

        }

        private void dánhachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT *  FROM Employee WHERE code = @code";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("code", txtTimKiem.Text);
            cmd.Parameters.AddWithValue("name", txttennv.Text);
            cmd.Parameters.AddWithValue("position", txtvitri.Text);
            cmd.Parameters.AddWithValue("roleId", txtquyen.Text);
            cmd.Parameters.AddWithValue("username", txttk.Text);
            cmd.Parameters.AddWithValue("password", txtmk.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            danhsachNhanVien.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Trangchu f = new Trangchu();
            f.Show();
            this.Hide();
        }
    }
}
