using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private string maSP;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        private string tenSP;

        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        private string thongtin;

        public string Thongtin
        {
            get { return thongtin; }
            set { thongtin = value; }
        }
        private int giatien;

        public int Giatien
        {
            get { return giatien; }
            set { giatien = value; }
        }
        private string maloaiSP;

        public string MaloaiSP
        {
            get { return maloaiSP; }
            set { maloaiSP = value; }
        }
        private string anhminhhoa;

        public string Anhminhhoa
        {
            get { return anhminhhoa; }
            set { anhminhhoa = value; }
        }
        private bool trangthai;

        public bool Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
