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

namespace ttn_detai5
{
    public partial class FormChiTietHoaDon : Form
    {
        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();
        DBAccess access = new DBAccess();
        DataTable table,table2;

        string mahd = FormQuanLiHoaDon.mahd;
        public FormChiTietHoaDon()
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormChiTietHoaDon_Load(object sender, EventArgs e)
        {
            lblMaHD.Text = mahd;
            table = new DataTable();
            table2 = new DataTable();
            string queryChiTietPhong = "SELECT * FROM dbo.HOADON_PHONG " +
                " WHERE MaHD = '" + mahd + "'";
            GetData(queryChiTietPhong, dataGridViewPhong, table);

            string queryChiTietDichVu = "SELECT * FROM dbo.HOADON_DICHVU " +
                " WHERE MaHD = '" + mahd + "'";
            GetData(queryChiTietDichVu, dataGridViewDichVu, table2);

        }
    }
}
