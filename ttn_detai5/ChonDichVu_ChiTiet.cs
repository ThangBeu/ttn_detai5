using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttn_detai5
{
    class ChonDichVu_ChiTiet
    {
        string maDV;
        string tenDV;
        string donGio;
        string soLuong;
        string thanhTien;

        public ChonDichVu_ChiTiet(string maDV, string tenDV, string donGio, string soLuong, string thanhTien)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.donGio = donGio;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
        }

        public string MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public string DonGio { get => donGio; set => donGio = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
