using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttn_detai5
{
    class ChonPhong_ChiTiet
    {
        string maPhong;
        string tenPhong;
        string donGia;
        DateTime ngayKhachDen;
        DateTime ngayKhachDi;
        string thanhTien;

        public ChonPhong_ChiTiet(string maPhong, string tenPhong, string donGia, DateTime ngayKhachDen, DateTime ngayKhachDi, string thanhTien)
        {
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
            this.donGia = donGia;
            this.ngayKhachDen = ngayKhachDen;
            this.ngayKhachDi = ngayKhachDi;
            this.thanhTien = thanhTien;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public DateTime NgayKhachDen { get => ngayKhachDen; set => ngayKhachDen = value; }
        public DateTime NgayKhachDi { get => ngayKhachDi; set => ngayKhachDi = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
