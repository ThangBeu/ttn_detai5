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
    public partial class FormThanhToan : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table, table2, table3;
        string hoten, gioitinh, sdt, diachi, cmnd, maKH;
        string maPhong, TenPhong, DonGiaPhong, SoLuongPhong;
        string maDV, TenDV, DonGiaDV, SoLuongDV;
        string fromdate, todate;

        private void dataGridChonPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridChonPhong.Rows[index];
            fromdate = System.DateTime.Today.ToString("dd-MM-yyyy");
            todate = System.DateTime.Today.ToString("dd-MM-yyyy");
           
            this.dataGridChiTietPhong.Rows.Add(
                selectRow.Cells[0].Value.ToString(),
                selectRow.Cells[1].Value.ToString(),
                selectRow.Cells[2].Value.ToString(),
                fromdate,
                todate,
                selectRow.Cells[2].Value.ToString())
                ;
        }

        private void dataGridChiTietPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridChiTietPhong.Rows[index];
            textBoxTenPhong.Text = selectRow.Cells[1].Value.ToString();
            dateTimePickerDen.Value = Convert.ToDateTime(selectRow.Cells[3].Value.ToString());
            dateTimePickerDi.Value = Convert.ToDateTime(selectRow.Cells[4].Value.ToString());
        }

        private void dataGridDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridDichVu.Rows[index];

            this.dataGridChiTietDichVu.Rows.Add(
                selectRow.Cells[0].Value.ToString(),
                selectRow.Cells[1].Value.ToString(),
                selectRow.Cells[2].Value.ToString(),
                0)
                ;
        }

        private void dataGridChiTietDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridChiTietDichVu.Rows[index];
            textBoxTenDV.Text = selectRow.Cells[1].Value.ToString();
            numericUpDownSLDV.Value = Convert.ToDecimal(selectRow.Cells[3].Value);
        }

        private void addComboBox(SqlConnection conn, SqlCommand cmd, List<string> list, string tenCot, string tenTable, ComboBox cb)
        {
            conn.Open();
            cmd = new SqlCommand("Select " + tenCot + " FROM " + tenTable, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr.GetInt32(0).ToString());
            }
            cb.DataSource = list;
            conn.Close();

        }

        public FormThanhToan()
        {
            InitializeComponent();
            innit();
        }


        public void innit()
        {
            List<string> list = new List<string>();
            addComboBox(conn, cmd, list, "MaKH", "KHACHANG", comboBoxMaKH);

            textBoxMaNV.Text = FormLogin.maNV.ToString();
            dateTimePickerDen.Format = DateTimePickerFormat.Custom;
            dateTimePickerDen.CustomFormat = "dd-MM-yyyy";
            dateTimePickerDi.Format = DateTimePickerFormat.Custom;
            dateTimePickerDi.CustomFormat = "dd-MM-yyyy";

            table2 = new DataTable();
            GetData("select * from PHONG", dataGridChonPhong, table2);
            table3 = new DataTable();
            GetData("select * from DICHVU", dataGridDichVu, table3);

            dataGridChiTietPhong.Columns.Add("Column", "Mã phòng");
            dataGridChiTietPhong.Columns.Add("Column", "Tên Phòng");
            dataGridChiTietPhong.Columns.Add("Column", "Đơn Giá");
            dataGridChiTietPhong.Columns.Add("Column", "Ngày đến");
            dataGridChiTietPhong.Columns.Add("Column", "Ngày đi");
            dataGridChiTietPhong.Columns.Add("Column", "Thành tiền");

            dataGridChiTietDichVu.Columns.Add("Column", "Mã dịch vụ");
            dataGridChiTietDichVu.Columns.Add("Column", "Tên dịch vụ");
            dataGridChiTietDichVu.Columns.Add("Column", "Đơn giá");
            dataGridChiTietDichVu.Columns.Add("Column", "Số lượng");
            dataGridChiTietDichVu.Columns.Add("Column", "Thành tiền");
        }

        private void GetData(string query, DataGridView grid, DataTable table)
        {
            access.createConn();
            adt = new SqlDataAdapter(query, conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
