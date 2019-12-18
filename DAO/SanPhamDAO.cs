using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class SanPhamDAO
    {
       public static DataTable LayDSSanPham() {
           string query = "select * from SanPham";
           SqlParameter[] param = new SqlParameter[0];
           return DataProvider.ExecuteSelectQuery(query, param);
       }
       public static SanPhamDTO LaySanPhamTheoMaSP(string masp)
       {
           string query = "select * from SanPham where MaSP=@MaSP";
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@MaSp", masp);
           DataRow dr = DataProvider.ExecuteSelectQuery(query, param).Rows[0];
           SanPhamDTO sp = new SanPhamDTO();
           sp.MaSP = dr["MaSP"].ToString();
           sp.TenSP = dr["TenSP"].ToString();
           sp.Thongtin = dr["ThongTin"].ToString();
           sp.Giatien = Convert.ToInt32(dr["GiaTien"]);
           sp.MaloaiSP = dr["MaLoaiSP"].ToString();
           sp.Anhminhhoa = dr["AnhMinhHoa"].ToString();
           sp.Trangthai = Convert.ToBoolean(dr["TrangThai"]);
           return sp;
          

       }

       public static SanPhamDTO ConvertToDTO(DataRow dr) {
           SanPhamDTO sp = new SanPhamDTO();
           sp.MaSP = dr["MaSP"].ToString();
           sp.TenSP = dr["TenSP"].ToString();
           sp.Thongtin = dr["ThongTin"].ToString();
           sp.Giatien = Convert.ToInt32(dr["GiaTien"]);
           sp.MaloaiSP = dr["MaLoaiSP"].ToString();
           sp.Anhminhhoa = dr["AnhMinhHoa"].ToString();
           sp.Trangthai = Convert.ToBoolean(dr["TrangThai"]);
           return sp;
       }
       public static SizeDTO ConvertToDTOSize(DataRow dr) {
           SizeDTO si = new SizeDTO();
           si.Id = Convert.ToInt32(dr["id"]);
           si.Sizenumber = dr["sizenumber"].ToString();
           si.Masp_id = dr["masp_id"].ToString();
           si.Soluongtonkho = Convert.ToInt32(dr["SoLuongTonKho"]);
           return si;
       }
       public static List<SizeDTO> LaySanPhamTheoSize(string masp) {
           string query = "select * from SanPham sp, Size sz where sz.masp_id = sp.MaSp and sp.MaSP = @masp";
           SqlParameter[] param = new SqlParameter[1];
           param[0] = new SqlParameter("@MaSp", masp);
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query,param);
            List<SizeDTO> lsSize = new List<SizeDTO>();
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lsSize.Add(ConvertToDTOSize(dr));
            }
            return lsSize;
       }
    }
}
