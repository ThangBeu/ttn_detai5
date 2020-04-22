using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttn_detai5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void AddForm(Form f)
        {
            f.MdiParent = this;
            groupBoxView.Controls.Add(f);
            f.Show();
        }
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            FormPhong f = new FormPhong();
            AddForm(f);
        }

        private void groupBoxView_Enter(object sender, EventArgs e)
        {

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            FormKhachHang f = new FormKhachHang();
            AddForm(f);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            FormThanhToan f = new FormThanhToan();
            f.ShowDialog();
        }

        private void btnNhanVienQuanLy_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            FormQuanLiNhanVien f = new FormQuanLiNhanVien();
            AddForm(f);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void init(object sender, EventArgs e)
        {
            btnNhanVienQuanLy.Enabled = false;
            btnQuanLiHoaDon.Enabled = false;
            txtHoTen.Text = FormLogin.ten;
            txtSoDienThoai.Text = FormLogin.phone;
            txtNgaySinh.Text = FormLogin.ngaySinh;
            if (FormLogin.quyen.Equals("1"))
            {
                txtViTri.Text = "Quản Lý";
                btnNhanVienQuanLy.Enabled = true;
                btnQuanLiHoaDon.Enabled = true;
            }
            else
            {
                txtViTri.Text = "Nhân Viên";
            }

            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxView.Controls.Clear();
            FormQuanLiHoaDon f = new FormQuanLiHoaDon();
            AddForm(f);
        }
    }
}
