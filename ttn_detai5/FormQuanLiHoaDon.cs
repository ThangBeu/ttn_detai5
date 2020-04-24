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
    public partial class FormQuanLiHoaDon : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table, table2, table3;

        string manv, makh, tongtien, tongtiendv, tongtienphong;
        public static string mahd;
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (mahd == null)
            {
                MessageBox.Show("Vui lòng chọn 'Mã hóa đơn' để thực hiện xem Chi Tiết thông tin");
            }
            else
            {
                FormChiTietHoaDon f = new FormChiTietHoaDon();
                f.Show();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (mahd == null)
            {
                MessageBox.Show("Vui lòng chọn 'Mã Hóa đơn' để thực hiện Xóa");
            }
            else
            {
                table = new DataTable();
                string queryDelete = "delete dbo.HOADON where MaHD = N'" + mahd + "' ";
                string queryDelete1 = "delete dbo.HOADON_PHONG where MaHD = N'" + mahd + "' ";
                string queryDelete2 = "delete dbo.HOADON_DICHVU where MaHD = N'" + mahd + "' ";
                GetData(queryDelete1, dataGridViewHD, table);
                GetData(queryDelete2, dataGridViewHD, table);
                GetData(queryDelete, dataGridViewHD, table);
                GetData("select * from dbo.HOADON", dataGridViewHD, table);
                MessageBox.Show("Done");
            }
        }

        private void FormQuanLiHoaDon_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            GetData("select * from HOADON", dataGridViewHD, table);
        }

        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            string key = txtSearchHD.Text.Trim();
            if (key.Equals(""))
            {
                string query = "SELECT * FROM dbo.HOADON";
                GetData(query, dataGridViewHD, table);
            }
            else
            {
                string query = "SELECT * FROM dbo.HOADON WHERE MaHD = '" + key + "' OR MaNV = '" + key + "' OR MaKH = '" + key + "' ";
                GetData(query, dataGridViewHD, table);
            }
        }

        public FormQuanLiHoaDon()
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

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridViewHD.Rows[index];
            mahd = selectRow.Cells[0].Value.ToString();
            manv = selectRow.Cells[1].Value.ToString();
            makh = selectRow.Cells[2].Value.ToString();
            tongtien = selectRow.Cells[3].Value.ToString();
            tongtiendv = selectRow.Cells[4].Value.ToString();
            tongtienphong = selectRow.Cells[5].Value.ToString();


            //cbID_teacher.Text = teacher_id;
        }
    }
}
