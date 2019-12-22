using System;
using System.Data;

public partial class Pages_FrontEnd : System.Web.UI.MasterPage
{
    DanhMucBUS danhMucBUS = new DanhMucBUS();
    NhomSP_BUS nhomSP_BUS = new NhomSP_BUS();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadMenu();
        }
    }

    void LoadMenu()
    {
        DataTable dtDanhMuc = danhMucBUS.LayDanhSachDanhMuc();
        DataTable dtNhom = nhomSP_BUS.LayDanhSachNhomSPOnly();
        ltrMenuRight.Text = "";
        ltrMenu.Text = @"<div class='row' style='z-index: 2'>
                      <div class='col-lg-12'>
                        <div id = 'menu'>
                             <ul>
                                <li><a href='Home.aspx'>TRANG CHỦ</a></li>
                                <li><a href='Introduce.aspx'>GIỚI THIỆU</a></li>";
        for (int i = 0; i < dtDanhMuc.Rows.Count; i++)
        {
            string title = dtDanhMuc.Rows[i]["tenDM"].ToString();

            ltrMenuRight.Text += @"<li>
                                <a href='Home.aspx?type=main&dm=" + dtDanhMuc.Rows[i]["maDM"] + @"'>" + title + @"</a></li>";

            if (title.Contains("BÚT") || title.Contains("GIẤY") || title.Contains("SỔ"))
            {
                title = title.Split(' ')[0];
            }

            ltrMenu.Text += @"<li>
                                <a href='Home.aspx?type=main&dm=" + dtDanhMuc.Rows[i]["maDM"] + @"'>" + title + @"</a>
                              <ul class='sub_menu'>";
            for (int j = 0; j < dtNhom.Rows.Count; j++)
            {
                if (dtNhom.Rows[j]["maDM"].ToString() == dtDanhMuc.Rows[i]["maDM"].ToString())
                {
                    ltrMenu.Text += @"<li class='sub2'><a href='Home.aspx?type=sub-main&dm=" + dtDanhMuc.Rows[i]["maDM"] + @"&nhom=" + dtNhom.Rows[j]["maNhomSP"] + @"'>" + dtNhom.Rows[j]["tenNhomSP"] + @"</a></li>";
                }
            }

            ltrMenu.Text += @"</ul>
                </li>";
        }

        ltrMenu.Text += @"<li><a href='#'>LIÊN HỆ</a></li>
                           <li><a href='#'>TIN TỨC</a></li>
                            </ul>
                        </div>
                    </div>
                </div>";
    }

    protected void btnTimKiem_Click(object sender, EventArgs e)
    {
        string textToSearch = txtTimKiem.Text.Trim();

        if (textToSearch != "")
        {
            textToSearch = textToSearch.Replace(' ', '-');
            Response.Redirect("Home.aspx?type=search&submit=" + textToSearch);
        }
    }
}
