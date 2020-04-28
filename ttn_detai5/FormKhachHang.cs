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
using ttn_detai5;

namespace ttn_detai5
{
    public partial class FormKhachHang : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table;
        int maKH = -1;
        string ten, diaChi, sdt, gioiTinh, soCMND;

      

        public FormKhachHang()
        {
            InitializeComponent();
        }

     

        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

      


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            ten = selectRow.Cells[1].Value.ToString();
            gioiTinh = selectRow.Cells[2].Value.ToString();
            diaChi = selectRow.Cells[4].Value.ToString();
            sdt = selectRow.Cells[3].Value.ToString();
            soCMND = selectRow.Cells[5].Value.ToString();
            maKH = int.Parse(selectRow.Cells[0].Value.ToString());
              
            txtTen.Text = ten;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;
            txtSoCMND.Text = soCMND;
            txtMaKH.Text = maKH.ToString();
                    
            if (gioiTinh.Equals("True")) radioButtonNam.Checked = true;
            else radioButtonNu.Checked = true;
            }
            catch
            {

            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ten = txtTen.Text.Trim();
            diaChi = txtDiaChi.Text;
            sdt = txtSDT.Text;
            soCMND = txtSoCMND.Text;
            if (radioButtonNam.Checked == true)
            {
                gioiTinh = "1";
            }
            else
            {
                gioiTinh = "0";
            }
            if (ten.Equals("") || diaChi.Equals("") || sdt.Equals("") || gioiTinh.Equals("") || soCMND.Equals(""))
            {
                MessageBox.Show("Thieu Thong tin");

            }
            else
            {
                conn.Open();
                table = new DataTable();
                string queryInsert = "INSERT dbo.KHACHHANG( HoTen, GioiTinh, SDT, DiaChi, SoCMND )VALUES" +
                    "  ( N'"+ten+"','"+gioiTinh+"','"+sdt+"',N'"+diaChi+"','"+soCMND+"')";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Them Khach Hang Thanh Cong");
                    conn.Close();
                    string query = "SELECT * FROM dbo.KHACHHANG";
                    GetData(query, dataGridView1, table);
                }
            }
        } 
        private void btnSua_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            ten = txtTen.Text.Trim();
            sdt = txtSDT.Text;
            diaChi = txtDiaChi.Text;
            soCMND = txtSoCMND.Text;
            if (radioButtonNam.Checked == true)
            {
                gioiTinh = "1";
            }
            else
            {
                gioiTinh = "0";
            }
            if (ten.Equals("") || diaChi.Equals("") || sdt.Equals("") || gioiTinh.Equals("") || soCMND.Equals(""))
            {
                MessageBox.Show("Thieu Thong tin");

            }
            else
            {
                conn.Close();
                conn.Open();
                table = new DataTable();
                string queryInsert = "UPDATE dbo.KHACHHANG SET HoTen = N'"+ten+"', GioiTinh = '"+gioiTinh+"', SDT = '"+sdt+"', DiaChi = N'"+diaChi+"', SoCMND = '"+soCMND+"'" +
                "Where MaKH = '"+maKH+"'";
                cmd = new SqlCommand(queryInsert, conn);
                cmd.CommandType = CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Sua Khach Hang Thanh Cong");
                    conn.Close();
                    string query = "SELECT * FROM dbo.KHACHHANG";
                    GetData(query, dataGridView1, table);
                }
            }
        } 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maKH == -1)
            {
                MessageBox.Show("Chua Chon Khach Hang De Xoa");
            }
            else
            {
                table = new DataTable();
                string query1 = "UPDATE dbo.HOADON SET MaKH = NULL WHERE MaKH = '"+maKH+"'";
                string query2 = "DELETE dbo.KHACHHANG WHERE MaKH = '"+maKH+"'";
                GetData(query1, dataGridView1, table);
                GetData(query2, dataGridView1, table);
                GetData("SELECT * FROM dbo.KHACHHANG", dataGridView1, table);
                MessageBox.Show("Xóa Thành Công");

            }
        } 
        private void btnSearchKH_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = txtSearchKH.Text.Trim();
            if (key.Equals(""))
            {
                string query = "SELECT * FROM dbo.KHACHHANG";
                GetData(query, dataGridView1, table);
            }
            else
            {
                int a;
                bool check = int.TryParse(key, out a);
                if (check == true)
                {
                    string query = "SELECT * FROM dbo.KHACHHANG WHERE MaKH = '"+key+"' OR GioiTinh = '"+key+"' OR SDT LIKE '%"+key+"%' OR SoCMND LIKE '%"+key+"%'";
                    GetData(query, dataGridView1, table);
                }
                else
                {
                    string query = "SELECT * FROM dbo.KHACHHANG WHERE HoTen LIKE N'%"+key+"%' OR DiaChi LIKE N'%"+key+"%'";
                    GetData(query, dataGridView1, table);
                }

            }
        }
                    
    }
}
   