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
    public partial class FormQuanLiNhanVien : Form
    {
        DBAccess access = new DBAccess();
        DataTable table;

        //private static string strConn = "Data Source=MAYTINH-JCRJIC4;Initial Catalog=TTCSDL;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        
        string ten;
        string ngaySinh;
        string gioiTinh;
        string diaChi;
        string sdt;
        string luong;
        string taiKhoan;
        string matKhau;
        string quyen;

        int manv;

        public FormQuanLiNhanVien()
        {
            InitializeComponent();
            comboBoxColumn.SelectedItem = comboBoxColumn.Items[0];
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }
        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private bool CheckTaiKhoan(string query, DataTable table)
        {
            access.readDataToAdapter(query, table);
            int a = table.Rows.Count;
            if (a != 0)
            {
                MessageBox.Show("Tài Khoản đã bị trùng với người khác, Vui lòng sử dụng tên tài khoản khác!");
                return false;
            }
            return true;
        }
        private bool CheckThieuThongTin()
        {
            ten = txtTenNVQL.Text;
            gioiTinh = txtGioiTinhNVQL.Text;
            diaChi = txtdiaChiNVQL.Text;
            luong = txtLuongNVQL.Text;
            sdt = txtSdtNVQL.Text;
            quyen = txtQuyenHanNVQL.Text;
            taiKhoan = txtTaiKhoanNVQL.Text;
            matKhau = txtMatKhauNVQL.Text;
            ngaySinh = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
          //  MessageBox.Show(ngaySinh);
            if (taiKhoan.Equals("") || ten.Equals("") || gioiTinh.Equals("") || diaChi.Equals("")
                || luong.Equals("") || sdt.Equals("") || quyen.Equals("") || matKhau.Equals(""))
            {
                MessageBox.Show("Thiếu thông tin !!");
                return true;
            }
            return false;
        }

        private void FormQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("select * from NHANVIEN", gridView2, table);
        }

        private void GridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = gridView2.Rows[index];
                txtTenNVQL.Text = selectRow.Cells[1].Value.ToString().Trim();
                dateTimePicker1.Value = Convert.ToDateTime(selectRow.Cells[2].Value.ToString().Trim());
                txtGioiTinhNVQL.Text = selectRow.Cells[3].Value.ToString().Trim();
                txtdiaChiNVQL.Text = selectRow.Cells[4].Value.ToString().Trim();
                txtLuongNVQL.Text = selectRow.Cells[6].Value.ToString().Trim();
                txtSdtNVQL.Text = selectRow.Cells[5].Value.ToString().Trim();
                
                txtQuyenHanNVQL.Text = selectRow.Cells[9].Value.ToString().Trim();
                txtTaiKhoanNVQL.Text = selectRow.Cells[7].Value.ToString().Trim();
                txtMatKhauNVQL.Text = selectRow.Cells[8].Value.ToString().Trim();

                manv = int.Parse(selectRow.Cells[0].Value.ToString().Trim());
            }
            catch
            {

            }
        }

        private void BtnThemQLNV_Click(object sender, EventArgs e)
        {
            if (CheckThieuThongTin() == false)
            {
                table = new DataTable();
                string query = "select * from NHANVIEN where TaiKhoan = N'" + taiKhoan + "'";
                if (CheckTaiKhoan(query, table) == true)
                {
                    conn.Open();
                    string queryInsert = "INSERT dbo.NHANVIEN( TenNV ,NgaySinh ,GioiTinh ,DiaChi ,SDT , Luong ,TaiKhoan ,MatKhau , Quyen) " +
                        "VALUES  ( N'" + ten + "' ,'"+ngaySinh+"','"+gioiTinh+"',N'"+diaChi+"' ,'"+sdt+"' ,'"+luong+"','"+taiKhoan+"' ,'"+matKhau+"' ,'"+quyen+"')";
                    GetData(queryInsert, gridView2, table);
                    GetData("select * from NhanVien", gridView2, table);
                    MessageBox.Show("DONE");
                }
            }
        }

        private void BtnSuaQLNV_Click(object sender, EventArgs e)
        {
            if (CheckThieuThongTin() == false)
            {
                
                
                 string queryUpdate = "UPDATE dbo.NHANVIEN SET TenNV = N'"+ten+"',NgaySinh = '"+ngaySinh+"',GioiTinh = '"+gioiTinh+"',DiaChi= N'"+diaChi+"', SDT = '"+sdt+"', Luong = '"+luong+"'" +
                        " , TaiKhoan = '"+taiKhoan+"', MatKhau = '"+matKhau+"', Quyen = '"+quyen+"' WHERE MaNV = '"+manv+"' ";
                 GetData(queryUpdate, gridView2, table);
                 GetData("select * from NHANVIEN", gridView2, table);
                 MessageBox.Show("DONE");
                
            }
        }

        private void BtnXoaQLNV_Click(object sender, EventArgs e)
        {
            if (CheckThieuThongTin() == false)
            {
                table = new DataTable();
                string queryDelete = "delete NHANVIEN where TaiKhoan = N'" + taiKhoan + "' ";
                GetData(queryDelete, gridView2, table);
                GetData("select * from NHANVIEN", gridView2, table);
                MessageBox.Show("DONE");
            }
        }

        private void TxtSearchQLNV_TextChanged(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = comboBoxColumn.Text;
            string keySearch = txtSearchQLNV.Text;
            switch (key)
            {
                case ("Mã Nhân Viên"):
                    {
                        GetData("select * from NhanVien where (MaNV like '%" + keySearch + "%')", gridView2, table);
                        break;
                    }
                case ("Tên Nhân Viên"):
                    {
                        GetData("select * from NhanVien where (TenNV like N'%" + keySearch + "%')", gridView2, table);
                        break;
                    }
                case ("Ngày Sinh"):
                    {
                        GetData("select * from NhanVien where (NgaySinh like '%" + keySearch + "%')", gridView2, table);
                        break;
                    }
                case ("Giới Tính"):
                    {
                        GetData("select * from NhanVien where (GioiTinh like '%" + keySearch + "%')", gridView2, table);
                        break;
                    }
                case ("Địa Chỉ"):
                    {
                        GetData("select * from NhanVien where (DiaChi like '%" + keySearch + "%')", gridView2, table);
                        break;
                    }
                case ("SĐT"):
                    {
                        GetData("select * from NhanVien where (SDT like '%" + keySearch + "%')", gridView2, table);
                        break;
                    }
                case ("Tài Khoản"):
                    {
                        GetData("select * from NhanVien where (TaiKhoan like '%" + keySearch + "%')", gridView2, table);
                        break;
                    }

            }
            if (keySearch == "")
            {
                GetData("select * from NHANVIEN", gridView2, table);
            }
        }
    }
}
