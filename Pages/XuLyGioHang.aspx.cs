using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_XuLyGioHang : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        thaotac = Request.Params["ThaoTac"];
        switch (thaotac)
        {
            case "LayTongTienTrongGioHang":
                LayTongTienTrongGioHang();
                break;

            case "XoaSPTrongGioHang":
                XoaSPTrongGioHang();
                break;

            case "CapNhatSoLuongVaoGioHang":
                CapNhatSoLuongVaoGioHang();
                break;
            case "LayThongTinGioHang":
                LayThongTinGioHang();
                break;

        }
    }

    private void LayThongTinGioHang()
    {
        string ketQua = "Không có sản phẩm nào trong giỏ hàng!";

        if (Session["GioHang"] != null)
        {
            ketQua = "";
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            if (dtGioHang.Rows.Count == 0)
            {
                Response.Write(ketQua);
                return;
            }

            ketQua += @"
            <table id='cart-table'>
                <tbody>
                    <tr>
                        <th>STT</th>
                        <th>Ảnh</th>
                        <th>Tên sản phẩm</th>
                        <th>Số lượng</th>
                        <th>Đơn giá</th>
                        <th></th>
                    </tr>";


            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                ketQua += @"
                    <tr class='line-item' id='tr_" + dtGioHang.Rows[i]["maSP"] + @"'>
                        <td class='item-stt' style='width=20px; text-align:center;'>" + (i + 1) + @"</td>
                        <td class='item-image'><img class='anhSPGioHang' style='width: 80px;' src='../Images/" + dtGioHang.Rows[i]["anhSP"] + @"' /></td>
                        <td class='item-title'>
                            <a href='Home.aspx?type=detail&id=" + dtGioHang.Rows[i]["maSP"] + @"'>" + dtGioHang.Rows[i]["tenSP"] + @"</a>
                        </td>
                        <td class='item-quantity'><input size='50' onchange='CapNhatSoLuongVaoGioHang(" + dtGioHang.Rows[i]["maSP"] + @")' id='quantity_" + dtGioHang.Rows[i]["maSP"] + @"' name='updates[]' min='1' type='number' value='" + dtGioHang.Rows[i]["soLuong"] + @"' class=''></td>
                        <td class='item-price'>" + dtGioHang.Rows[i]["giaBan"] + @"</td>
                        <td class='item-delete'><a href='javascript://' onclick='XoaSPTrongGioHang(" + dtGioHang.Rows[i]["MaSP"] + @")'>Xóa</a></td>
                    </tr>
            ";
            }

            ketQua += @"
                </tbody>
            </table>
            ";
        }

        Response.Write(ketQua);
    }

    private void CapNhatSoLuongVaoGioHang()
    {
        string idSanPham = Request.Params["idSanPham"];
        string soLuongMoi = Request.Params["soLuongMoi"];

        if (Session["GioHang"] != null)
        {
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == idSanPham)
                    dtGioHang.Rows[i]["SoLuong"] = soLuongMoi;
            }

            Session["GioHang"] = dtGioHang;
        }

        Response.Write("");
    }


    private void XoaSPTrongGioHang()
    {
        string idSanPham = Request.Params["idSanPham"];

        if (Session["GioHang"] != null)
        {
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == idSanPham)
                    dtGioHang.Rows[i].Delete();
            }

            Session["GioHang"] = dtGioHang;
        }

        Response.Write("");
    }


    private void LayTongTienTrongGioHang()
    {
        double tongTien = 0;

        if (Session["GioHang"] != null)
        {
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongTien += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * double.Parse(dtGioHang.Rows[i]["GiaBan"].ToString());
            }
        }

        Response.Write(tongTien);
    }
}