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

    }
}
