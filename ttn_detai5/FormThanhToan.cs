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

        string id = "";
        List<ChonPhong_ChiTiet> chonPhong_ChiTiets = new List<ChonPhong_ChiTiet>();
        List<ChonDichVu_ChiTiet> chonDichVu_ChiTiets = new List<ChonDichVu_ChiTiet>();

        private void DateTimePickerDen_ValueChanged(object sender, EventArgs e)
        {
            foreach (ChonPhong_ChiTiet item in chonPhong_ChiTiets)
            {
                if (item.MaPhong == id)
                {
                    item.NgayKhachDen = Convert.ToDateTime(dateTimePickerDen.Value.ToString());

                    TimeSpan t = item.NgayKhachDi - item.NgayKhachDen;
                    int diff = (int)t.TotalDays + 1;
                    if (diff > 0)
                    {
                        item.ThanhTien = (diff * int.Parse(item.DonGia)).ToString();
                        RefeshSource_Phong();
                    }
                    else
                    {
                        MessageBox.Show("ngay di < ngay den");
                    }
                    
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach(ChonPhong_ChiTiet item in chonPhong_ChiTiets)
            {
                s += int.Parse(item.ThanhTien);
            }
            labelTotalRoomPrice.Text = s.ToString();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int soLuongDV = (int)numericUpDownSLDV.Value;
            foreach(ChonDichVu_ChiTiet item in chonDichVu_ChiTiets)
            {
                if(item.MaDV == id)
                {
                    item.SoLuong = soLuongDV.ToString();
                    item.ThanhTien = (int.Parse(item.SoLuong) * int.Parse(item.DonGio)).ToString();
                    RefeshSource_DichVu();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(id == "")
            {
                MessageBox.Show("ban chua dua ra lua chon");
            }
            else
            {   for(int i=0; i<chonPhong_ChiTiets.Count; i++)
                {
                    if(chonPhong_ChiTiets[i].MaPhong == id) chonPhong_ChiTiets.Remove(chonPhong_ChiTiets[i]);
                    RefeshSource_Phong();
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach(ChonDichVu_ChiTiet item in chonDichVu_ChiTiets)
            {
                s += int.Parse(item.ThanhTien);
            }
            labelTotalDVPrice.Text = s.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("ban chua dua ra lua chon");
            }
            else
            {
                for (int i = 0; i < chonDichVu_ChiTiets.Count; i++)
                {
                    if (chonDichVu_ChiTiets[i].MaDV == id) chonDichVu_ChiTiets.Remove(chonDichVu_ChiTiets[i]);
                    RefeshSource_DichVu();
                }
            }
        }

        private void DateTimePickerDi_ValueChanged(object sender, EventArgs e)
        {
            foreach(ChonPhong_ChiTiet item in chonPhong_ChiTiets)
            {
                if(item.MaPhong == id)
                {
                    item.NgayKhachDi = Convert.ToDateTime(dateTimePickerDi.Value.ToString());
                    
                    TimeSpan t = item.NgayKhachDi - item.NgayKhachDen;
                    int diff = (int)t.TotalDays + 1;
                    if (diff > 0)
                    {
                        item.ThanhTien = (diff * int.Parse(item.DonGia)).ToString();
                        RefeshSource_Phong();
                    }
                    else
                    {
                        MessageBox.Show("ngay di < ngay den");
                    }
                }
            }
        }

        string fromdate, todate;

        
        private void dataGridChonPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridChonPhong.Rows[index];
                fromdate = System.DateTime.Today.ToString("dd-MM-yyyy");
                todate = System.DateTime.Today.ToString("dd-MM-yyyy");

                string maPhong = selectRow.Cells[0].Value.ToString();
                //this.dataGridViewChiTietPhong.Rows.Add(
                //    selectRow.Cells[0].Value.ToString(),
                //    selectRow.Cells[1].Value.ToString(),
                //    selectRow.Cells[2].Value.ToString(),
                //    fromdate,
                //    todate,
                //    selectRow.Cells[2].Value.ToString())
                //    ;
                int temp = 0;
                DateTime d1 = DateTime.Now;
                foreach (ChonPhong_ChiTiet item in chonPhong_ChiTiets)
                {
                    if (item.MaPhong == maPhong) temp++;
                }

                if (temp == 0)
                {
                    chonPhong_ChiTiets.Add(new ChonPhong_ChiTiet(selectRow.Cells[0].Value.ToString(), selectRow.Cells[1].Value.ToString(),
                    selectRow.Cells[2].Value.ToString(), d1, d1.AddDays(+1), "0"));
                }

                RefeshSource_Phong();
                dataGridViewChiTietPhong.ClearSelection();
            }
            catch
            {

            }

            
        }
        private void RefeshSource_Phong()
        {
            var source = new BindingSource();
            source.DataSource = chonPhong_ChiTiets;
            dataGridViewChiTietPhong.DataSource = source;
        }
        private void RefeshSource_DichVu()
        {
            var source = new BindingSource();
            source.DataSource = chonDichVu_ChiTiets;
            dataGridChiTietDichVu.DataSource = source;
        }

        private void dataGridViewChiTietPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridViewChiTietPhong.Rows[index];
                textBoxTenPhong.Text = selectRow.Cells[1].Value.ToString();
                id = selectRow.Cells[0].Value.ToString();

                dateTimePickerDen.Value = Convert.ToDateTime(selectRow.Cells[3].Value.ToString());
                dateTimePickerDi.Value = Convert.ToDateTime(selectRow.Cells[4].Value.ToString());

            }
            catch
            {

            }
            dataGridViewChiTietPhong.ClearSelection();




        }

        private void dataGridDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridDichVu.Rows[index];
                string maDV = selectRow.Cells[0].Value.ToString();
                //this.dataGridChiTietDichVu.Rows.Add(
                //    selectRow.Cells[0].Value.ToString(),
                //    selectRow.Cells[1].Value.ToString(),
                //    selectRow.Cells[2].Value.ToString(),
                //    0)
                //    ;

                int temp = 0;
                foreach (ChonDichVu_ChiTiet item in chonDichVu_ChiTiets)
                {
                    if (item.MaDV == maDV)
                    {
                        temp++;
                    }
                }
                if (temp == 0)
                {
                    chonDichVu_ChiTiets.Add(new ChonDichVu_ChiTiet(maDV, selectRow.Cells[1].Value.ToString(), selectRow.Cells[2].Value.ToString(), "0", "0"));
                    RefeshSource_DichVu();
                }
            }
            catch
            {

            }
            dataGridChiTietDichVu.ClearSelection();

            
        }

        private void dataGridChiTietDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dataGridChiTietDichVu.Rows[index];
                textBoxTenDV.Text = selectRow.Cells[1].Value.ToString();
                //numericUpDownSLDV.Value = Convert.ToDecimal(selectRow.Cells[3].Value);

                id = selectRow.Cells[0].Value.ToString();
                numericUpDownSLDV.Value = int.Parse(selectRow.Cells[3].Value.ToString());
            }
            catch
            {

            }
            dataGridChiTietDichVu.ClearSelection();
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

            //dataGridViewChiTietPhong.Columns.Add("Column", "Mã phòng");
            //dataGridViewChiTietPhong.Columns.Add("Column", "Tên Phòng");
            //dataGridViewChiTietPhong.Columns.Add("Column", "Đơn Giá");
            //dataGridViewChiTietPhong.Columns.Add("Column", "Ngày đến");
            //dataGridViewChiTietPhong.Columns.Add("Column", "Ngày đi");
            //dataGridViewChiTietPhong.Columns.Add("Column", "Thành tiền");

            //dataGridChiTietDichVu.Columns.Add("Column", "Mã dịch vụ");
            //dataGridChiTietDichVu.Columns.Add("Column", "Tên dịch vụ");
            //dataGridChiTietDichVu.Columns.Add("Column", "Đơn giá");
            //dataGridChiTietDichVu.Columns.Add("Column", "Số lượng");
            //dataGridChiTietDichVu.Columns.Add("Column", "Thành tiền");

            
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
