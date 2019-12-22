using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class CSS_admin_SanPham_QuanLiSanPham_HienThiDanhSachSanPham : System.Web.UI.UserControl
{
    SanPhamBUS sanPhamBUS = new SanPhamBUS();
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
    DataTable dtDM = new DataTable();
    DataTable dtNhom = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        dtDM = danhMucBUS.LayDanhSachDanhMuc();
        dtNhom = nhomSP_BUS.LayDanhSachNhomSPOnly();
        if (!IsPostBack)
        {
            LayDanhMuc();
            LayNhom();
            LaySanPham();
        }
    }

    private void LayNhom()
    {
        ddlNhomSP.Items.Clear();
        ddlNhomSP.Items.Add(new ListItem("Tất cả", "tatca"));
        ddlNhomSP.SelectedValue = "tatca";
        for (int i = 0; i < dtNhom.Rows.Count; i++)
        {
            if (dtNhom.Rows[i]["maDM"].ToString() == ddlDanhMucCha.SelectedValue.ToString())
                ddlNhomSP.Items.Add(new ListItem(dtNhom.Rows[i]["tenNhomSP"].ToString(), dtNhom.Rows[i]["maNhomSP"].ToString()));
        }
    }
    private void LayDanhMuc()
    {
        ddlDanhMucCha.Items.Clear();
        ddlDanhMucCha.Items.Add(new ListItem("Tất cả", "tatca"));
        ddlDanhMucCha.SelectedValue = "tatca";
        for (int i = 0; i < dtDM.Rows.Count; i++)
        {
            ddlDanhMucCha.Items.Add(new ListItem(dtDM.Rows[i]["tenDM"].ToString(), dtDM.Rows[i]["maDM"].ToString()));
        }
    }

    private void LaySanPham()
    {
        DataTable dt = new DataTable();
        dt = sanPhamBUS.LayDanhSachSP();
        ltrSanPham.Text = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (ddlDanhMucCha.SelectedValue == "tatca")
            {
                if (ddlNhomSP.SelectedValue == "tatca")
                    ltrSanPham.Text += @"
                        <tr id='maDong_" + dt.Rows[i]["maSP"] + @"'>
                                <td class='cotMa'>" + dt.Rows[i]["maSP"] + @"</td>
                                <td class='cotTen'>" + dt.Rows[i]["tenSP"] + @"</td>
                                <td class='cotAnh'>
                                    <img class='anhDaiDien'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                    <img class='anhDaiDienHover'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                </td>
                                <td class='cotDonGia'>" + dt.Rows[i]["giaBan"] + @"</td>
                                <td class='cotCongCu'>
                                    <a href='Admin.aspx?module=san-pham&cat=qlsp&thaotac=chinh-sua&id=" + dt.Rows[i]["maSP"] + @"' class='sua' title='Sửa'></a>
                                    <a href='javascript:XoaSanPham(" + dt.Rows[i]["maSP"] + @")' class='xoa' title='Xóa'></a>
                                </td>
                        </tr>
                        ";
                else
                {
                    if (dt.Rows[i]["maNhomSP"].ToString() == ddlNhomSP.SelectedValue)
                    {
                        ltrSanPham.Text += @"
                        <tr id='maDong_" + dt.Rows[i]["maSP"] + @"'>
                                <td class='cotMa'>" + dt.Rows[i]["maSP"] + @"</td>
                                <td class='cotTen'>" + dt.Rows[i]["tenSP"] + @"</td>
                                <td class='cotAnh'>
                                    <img class='anhDaiDien'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                    <img class='anhDaiDienHover'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                </td>
                                <td class='cotDonGia'>" + dt.Rows[i]["giaBan"] + @"</td>
                                <td class='cotCongCu'>
                                    <a href='Admin.aspx?module=san-pham&cat=qlsp&thaotac=chinh-sua&id=" + dt.Rows[i]["maSP"] + @"' class='sua' title='Sửa'></a>
                                    <a href='javascript:XoaSanPham(" + dt.Rows[i]["maSP"] + @")' class='xoa' title='Xóa'></a>
                                </td>
                        </tr>
                        ";
                    }
                }
            }
            else
            {
                if (ddlNhomSP.SelectedValue == "tatca")
                {
                    if (dt.Rows[i]["maDM"].ToString() == ddlDanhMucCha.SelectedValue.ToString())
                    {
                        ltrSanPham.Text += @"
                        <tr id='maDong_" + dt.Rows[i]["maSP"] + @"'>
                                <td class='cotMa'>" + dt.Rows[i]["maSP"] + @"</td>
                                <td class='cotTen'>" + dt.Rows[i]["tenSP"] + @"</td>
                                <td class='cotAnh'>
                                    <img class='anhDaiDien'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                    <img class='anhDaiDienHover'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                </td>
                                <td class='cotDonGia'>" + dt.Rows[i]["giaBan"] + @"</td>
                                <td class='cotCongCu'>
                                    <a href='Admin.aspx?module=san-pham&cat=qlsp&thaotac=chinh-sua&id=" + dt.Rows[i]["maSP"] + @"' class='sua' title='Sửa'></a>
                                    <a href='javascript:XoaSanPham(" + dt.Rows[i]["maSP"] + @")' class='xoa' title='Xóa'></a>
                                </td>
                        </tr>
                        ";
                    }
                }
                else
                {
                    if (dt.Rows[i]["maNhomSP"].ToString() == ddlNhomSP.SelectedValue && dt.Rows[i]["maDM"].ToString() == ddlDanhMucCha.SelectedValue)
                    {
                        ltrSanPham.Text += @"
                        <tr id='maDong_" + dt.Rows[i]["maSP"] + @"'>
                                <td class='cotMa'>" + dt.Rows[i]["maSP"] + @"</td>
                                <td class='cotTen'>" + dt.Rows[i]["tenSP"] + @"</td>
                                <td class='cotAnh'>
                                    <img class='anhDaiDien'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                    <img class='anhDaiDienHover'src='../Images/" + dt.Rows[i]["anhSP"] + @"'/>
                                </td>
                                <td class='cotDonGia'>" + dt.Rows[i]["giaBan"] + @"</td>
                                <td class='cotCongCu'>
                                    <a href='Admin.aspx?module=san-pham&cat=qlsp&thaotac=chinh-sua&id=" + dt.Rows[i]["maSP"] + @"' class='sua' title='Sửa'></a>
                                    <a href='javascript:XoaSanPham(" + dt.Rows[i]["maSP"] + @")' class='xoa' title='Xóa'></a>
                                </td>
                        </tr>
                        ";
                    }
                }
            }

        }

    }

    protected void ddlDanhMucCha_SelectedIndexChanged(object sender, EventArgs e)
    {
        LayNhom();
        LaySanPham();
    }

    protected void ddlNhomSP_SelectedIndexChanged(object sender, EventArgs e)
    {
        LaySanPham();
    }
}