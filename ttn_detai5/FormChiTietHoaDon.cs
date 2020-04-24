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

            string queryChiTietPhong = "SELECT HDP.MaHDP,HDP.MaHD,HDP.MaP,P.DonGiaPhong,HDP.NgayDi,HDP.NgayDen,(DATEDIFF(DAY,HDP.NgayDen,HDP.NgayDi) * P.DonGiaPhong) AS 'chi phi phong' FROM dbo.HOADON_PHONG AS HDP, dbo.PHONG AS P "
                                + "WHERE HDP.MaP = P.MaP AND MaHD = '" + mahd + "' ";
            GetData(queryChiTietPhong, dataGridViewPhong, table);

            string queryChiTietDichVu = "SELECT HDDV.MaHDDV,HDDV.MaHD,HDDV.MaDV,HDDV.SoLuong,DV.DonGia, (DV.DonGia*HDDV.SoLuong) AS 'chi phi dv' FROM dbo.HOADON_DICHVU AS HDDV, dbo.DICHVU AS DV " +
                " WHERE HDDV.MaDV = DV.MaDV AND MaHD = '" + mahd + "'";
            GetData(queryChiTietDichVu, dataGridViewDichVu, table2);
        }
    }
}
