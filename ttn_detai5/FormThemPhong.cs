using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ttn_detai5
{
    public partial class FormThemPhong : Form
    {
        DBAccess access = new DBAccess();
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DataTable table;

        string variable;
        public FormThemPhong()
        {
            InitializeComponent();
        }
        private string queryID(SqlCommand sql , string colomn , string table , string dieuKien , string ndDieuKien) {
            conn.Open();
            cmd = new SqlCommand("SELECT " + colomn + " FROM " + table + " WHERE " + dieuKien + " = N'" + ndDieuKien + "'  " , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                variable = dr.GetInt32(0).ToString();
            }
            conn.Close();
            return variable;
        }
        private void btnThem_Click(object sender , EventArgs e) {
            string tenPhong, maPhong;
            int donGia;
            tenPhong = textBoxTen.Text.Trim();
            donGia = int.Parse(textBoxGia.Text.Trim());
            maPhong = queryID(cmd , "MaP" , "PHONG" , "TenP" , tenPhong);
            if(tenPhong.Equals("")) {
                MessageBox.Show("Nhập thiếu thông tin!");
            }
            else if(maPhong != null) {
                MessageBox.Show("Tên phòng đã tồn tại!");
            }
            else {
                conn.Open();
                string queryInsert = "INSERT INTO dbo.PHONG (TenP , DonGiaPhong) VALUES(N'" + tenPhong + "'," + donGia+ ")";
                cmd = new SqlCommand(queryInsert , conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Hide();
                MessageBox.Show("Thêm phòng thành công");
            }


        }

        private void textBoxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
