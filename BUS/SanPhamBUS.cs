using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;
namespace BUS
{
   public class SanPhamBUS
    {
       public static DataTable LayDSSanPham()
       {
           return SanPhamDAO.LayDSSanPham();
       }
       public static SanPhamDTO LaySanPhamTheoMaSP(string masp)
       {
           return SanPhamDAO.LaySanPhamTheoMaSP(masp);


       }
       public static List<SizeDTO> LaySanPhamTheoSize(string masp)
       {
           return SanPhamDAO.LaySanPhamTheoSize(masp);
       }
    }
}
