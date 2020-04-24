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
    public partial class FormThemDoDung : Form
    {
        DBAccess access = new DBAccess();
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        string variable;
        public FormThemDoDung()
        {
            InitializeComponent();
            addData();
        }
        private void addComboBox(SqlConnection conn , SqlCommand cmd , List<string> list , string tenCot , string tenTable , ComboBox cb) {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " From " + tenTable , conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                list.Add(dr.GetValue(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();
        }
        private void addData() {
            List<string> listPhong = new List<string>();
            List<string> listDD = new List<string>();
            addComboBox(conn , cmd , listPhong , "MaP" , "PHONG" , comboBoxMaPhong);
            addComboBox(conn , cmd , listDD , "TenDD" , "DODUNG" , comboBoxTenDD);
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
            string tenDoDung, maPhong,maDoDung;
            int soLuong;
            tenDoDung = comboBoxTenDD.Text.Trim();
            soLuong = Convert.ToInt32(numericUpDownSL.Value);
            maPhong = comboBoxMaPhong.Text.Trim();
            maDoDung = queryID(cmd , "MaDD" , "DODUNG" , "TenDD" , tenDoDung);
            if(soLuong.Equals(0)) {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
            }
            else {
                conn.Open();
                string query1 = "INSERT INTO dbo.CHITIETPHONG (MaP , MaDD,SoLuongDD) VALUES(N'" + maPhong + "',N'" + maDoDung + "','" + soLuong + "')";
                cmd = new SqlCommand(query1 , conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Hide();
                MessageBox.Show("Thêm vật dụng trong phòng thành công");
            }
        }
    }
}
