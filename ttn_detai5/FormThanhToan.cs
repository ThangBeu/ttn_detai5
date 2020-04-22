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

        string hoten, gioitinh, sdt, diachi, cmnd;
        public static int maNV;
        string fromdate, todate;


        public FormThanhToan()
        {
            InitializeComponent();
            txtTenNV.Text = FormLogin.ten.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            fromdate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
            todate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridView1.Rows[index];

                maNV = int.Parse(selectRow.Cells[0].Value.ToString());
                hoten = selectRow.Cells[1].Value.ToString();
                gioitinh = selectRow.Cells[2].Value.ToString();
                sdt = selectRow.Cells[3].Value.ToString();
                diachi = selectRow.Cells[4].Value.ToString();
                cmnd = selectRow.Cells[5].Value.ToString();
                txtTenKH.Text = hoten;
                txtSdtKH.Text = sdt;
                txtDchi.Text = diachi;
            }
            catch
            {

            }

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
            table = new DataTable();
            GetData("select * from KHACHANG", dataGridView1, table);
            table2 = new DataTable();
            GetData("select * from PHONG", dataGridView2, table2);
            table3 = new DataTable();
            GetData("select * from DICHVU", dataGridView3, table3);
        }
    }
}
