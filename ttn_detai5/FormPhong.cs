using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttn_detai5 {
    public partial class FormPhong : Form {
        DBAccess access = new DBAccess();
        DataTable table,table1,table2;

        private static SqlConnection conn = new SqlConnection(DBAccess.strConn);
        private static SqlDataAdapter adt = new SqlDataAdapter();
        private static SqlCommand cmd = new SqlCommand();

        int maPhong = -1;
        int maDoDung = -1;
        int donGia,soLuong;
        string tenPhong, tenDoDung;
        public FormPhong() {
            InitializeComponent();
            addData();
        }

        private void buttonThemPhong_Click(object sender , EventArgs e) {
            FormThemPhong form = new FormThemPhong();
            form.ShowDialog();
        }

        private void buttonThemVD_Click(object sender , EventArgs e) {
            FormThemDoDung form = new FormThemDoDung();
            form.ShowDialog();
        }

        private void GetData(string query , DataGridView grid , DataTable table) {
            access.createConn();
            adt = new SqlDataAdapter(query , conn);
            adt.Fill(table);
            grid.DataSource = table;
            conn.Close();
        }
        private void addData() {
            table = new DataTable();
            table1 = new DataTable();
            GetData("select * from PHONG" , tableMain , table);
        }
        private void tableMain_CellClick(object sender , DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            tableMain1.Visible = true;
            DataGridViewRow selectRow = tableMain.Rows[index];
            maPhong = int.Parse(selectRow.Cells[0].Value.ToString().Trim());
            tenPhong = selectRow.Cells[1].Value.ToString().Trim();
            donGia = int.Parse(selectRow.Cells[2].Value.ToString().Trim());
            table = new DataTable();
            string query = "select * from DODUNG_VIEW Where MaP=" + maPhong; 
            GetData(query , tableMain1 , table);
        }
        private void tableMain1_CellClick(object sender , DataGridViewCellEventArgs e) {
            int index = e.RowIndex;
            DataGridViewRow selectRow = tableMain1.Rows[index];

            maPhong = int.Parse(selectRow.Cells[0].Value.ToString().Trim());
            maDoDung = int.Parse(selectRow.Cells[1].Value.ToString().Trim());
            tenDoDung = selectRow.Cells[2].Value.ToString().Trim();
            soLuong = int.Parse(selectRow.Cells[3].Value.ToString().Trim());
        }
        private void btnXoaPhong_Click(object sender , EventArgs e) {
            if(maPhong == -1) {
                MessageBox.Show("Chưa chọn phòng nào để xoá");
            }
            else {
                table = new DataTable();
                string query1 = "UPDATE dbo.HOADON_PHONG SET MaP = NULL WHERE MaP = '" + maPhong + "'";
                string query2 = "UPDATE dbo.CHITIETPHONG SET MaP = NULL WHERE MaP = '" + maPhong + "'";
                string query3 = "DELETE dbo.PHONG WHERE MaP = " + maPhong;

                GetData(query1 , tableMain , table);
                GetData(query2 , tableMain , table);
                GetData(query3 , tableMain , table);
                GetData("select * from PHONG" , tableMain , table);
                MessageBox.Show("Done");
            }
        } private void btnXoaVD_Click(object sender , EventArgs e) {
            if(maDoDung == -1) {
                MessageBox.Show("Chưa chọn đồ dùng nào để xoá");
            }
            else {
                table = new DataTable();
                string query1 = "DELETE dbo.CHITIETPHONG WHERE MaDD = " + maDoDung;
                GetData(query1 , tableMain1 , table);
                MessageBox.Show("Done");

            }
        }
        private void txtSearchPhong_TextChanged(object sender , EventArgs e) {
            string keyword;
            keyword = txtSearchPhong.Text;
            table = new DataTable();
            GetData("select * from PHONG WHERE TenP LIKE N'%" + keyword + "%' " +
                "OR DonGiaPhong LIKE N'%" + keyword + "%' " 
                , tableMain , table);
        }

        private void buttonRefresh_Click(object sender , EventArgs e) {
            table = new DataTable();
            GetData("select * from PHONG" , tableMain , table);
            tableMain1.Visible = false;
        }

        private void btnSearchPhong_Click(object sender , EventArgs e) {
            string keyword;
            keyword = txtSearchPhong.Text;
            table = new DataTable();
            GetData("select * from PHONG WHERE TenP LIKE N'%" + keyword + "%' " +
                "OR DonGiaPhong LIKE N'%" + keyword + "%' "
                , tableMain , table);
        }
        private void textBoxSearchVD_TextChanged(object sender , EventArgs e) {
            string keyword;
            keyword = textBoxSearchVD.Text;
            table = new DataTable();
            GetData("select * from DODUNG_VIEW WHERE class_name LIKE N'%" + keyword + "%' " +
                "OR student_amount LIKE N'%" + keyword + "%' " +
                "OR homeroom_teacher_id LIKE N'%" + keyword + "%'"
                , tableMain , table);
        }
        private void buttonSearchVD_Click(object sender , EventArgs e) {
            string keyword;
            keyword = textBoxSearchVD.Text;
            table = new DataTable();
            GetData("select * from DODUNG_VIEW WHERE MaP LIKE N'%" + keyword + "%' " +
                "OR MaDD LIKE N'%" + keyword + "%' " +
                "OR SoLuongDD LIKE N'%" + keyword + "%'"+
                "OR TenDD LIKE N'%" + keyword + "%'"
                , tableMain , table);
        }
    }

}