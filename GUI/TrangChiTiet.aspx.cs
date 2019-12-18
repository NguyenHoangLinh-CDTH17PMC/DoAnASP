using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
namespace GUI
{
    public partial class TrangChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SanPhamDTO sp = SanPhamBUS.LaySanPhamTheoMaSP(Request.QueryString["masp"]);
                lblTen.Text = sp.TenSP;
                imgAnhMinhHoa.ImageUrl = "images/" + sp.Anhminhhoa;
                lblThongTin.Text = sp.Thongtin;
                lblGiaTien.Text = sp.Giatien.ToString();

                DropDownList_size.DataSource = SanPhamBUS.LaySanPhamTheoSize(Request.QueryString["masp"]);
                DropDownList_size.DataTextField = "sizenumber";
                DropDownList_size.DataValueField = "sizenumber";
                DropDownList_size.DataBind();
            }

        }
    }
}