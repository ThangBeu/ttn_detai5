using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNhom;

namespace ttn_detai5
{
    public partial class FormLogin : Form
    {
        DBAccess dbAccess = new DBAccess();
        DataTable dt = new DataTable();

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        public static string ten;
        public static string ngaySinh;
        public static string phone;
        public static string quyen;
        public static string TaiKhoan;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            TaiKhoan = txtUser.Text;
            string query = "SELECT * FROM dbo.NHANVIEN WHERE TaiKhoan = '"+txtUser.Text+"' AND MatKhau = '"+txtPassWord.Text+"' ";
            dbAccess.readDataToAdapter(query, dt);
            int a = dt.Rows.Count;
            if (a != 0)
            {
                this.Hide();
                adt = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adt.Fill(table);

                ten = table.Rows[0][1].ToString();
                ngaySinh = table.Rows[0][2].ToString();
                phone = table.Rows[0][5].ToString();
                quyen = table.Rows[0][9].ToString();

                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng !! Vui Lòng thử lại.");
                txtUser.Clear();
                txtPassWord.Clear();
                txtUser.Focus();
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
