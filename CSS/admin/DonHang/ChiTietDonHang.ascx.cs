using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_admin_DonHang_ChiTietDonHang : System.Web.UI.UserControl
{
    string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }

        if (!IsPostBack)
        {
            LoadDonHang();
            LayChiTietDonHang();
        }
    }

    void LoadDonHang()
    {
        DataTable dt = DonHang.LayDonHangTheoID(id);
        if (dt.Rows.Count > 0)
        {
            int maTinhTrang = int.Parse(dt.Rows[0]["tinhTrang"].ToString());
            string tinhTrang = "";
            switch (maTinhTrang)
            {
                case 0:
                    tinhTrang = "Chờ xác nhận";
                    break;
                case 1:
                    tinhTrang = "Đang giao hàng";
                    break;
                case 2:
                    tinhTrang = "Đã thanh toán";
                    break;
                case 3:
                    tinhTrang = "Đã hủy";
                    break;
                default:
                    tinhTrang = "Chờ xác nhận";
                    break;
            }

            tbDiaChi.Text = dt.Rows[0]["diaChi"].ToString();
            tbMaDH.Text = dt.Rows[0]["maDH"].ToString();
            tbHoTen.Text = dt.Rows[0]["hoTen"].ToString();
            tbEmail.Text = dt.Rows[0]["email"].ToString();
            tbNgayDat.Text = dt.Rows[0]["ngayLap"].ToString().Split(' ')[0];
            tbSDT.Text = dt.Rows[0]["dienThoai"].ToString();
            tbTinhTrang.Text = tinhTrang;
        }
    }

    void LayChiTietDonHang()
    {
        float tongTien = 0;
        DataTable dt = DonHang.LayChiTietDonHang(id);
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                float thanhTien = float.Parse(dt.Rows[i]["giaBan"].ToString()) * int.Parse(dt.Rows[i]["soLuong"].ToString());
                tongTien += thanhTien;
                ltrSanPham.Text += @"
                        <tr>
                                <td class='cotMa'>" + dt.Rows[i]["maSP"] + @"</td>
                                <td class='cotTen'>" + dt.Rows[i]["tenSP"] + @"</td>
                                <td class='cotAnh'>
                                    <img class='anhDaiDien'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                    <img class='anhDaiDienHover'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                </td>
                                <td class='cotDonGia'>" + dt.Rows[i]["giaBan"] + @"</td>
                                <td class='cotCongCu'>" + dt.Rows[i]["soLuong"] + @"</td>
                                <td class='cotCongCu'>" + thanhTien + @"</td>
                        </tr>
                        ";
            }

            ltrTongTien.Text = @"<span class='item-total'>" + tongTien + @"</span>";
        }
        else
        {
            ltrTongTien.Text = @"<span class='item-total'>" + 0 + @"</span>";
        }
    }
}