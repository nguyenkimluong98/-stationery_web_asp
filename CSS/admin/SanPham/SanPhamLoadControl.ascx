<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadControl.ascx.cs" Inherits="CSS_admin_SanPham_SanPhamLoadControl" %>
<link href="../styles.css" rel="stylesheet" />
<div class="container">
    <div style="clear:both; height: 20px;"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a href="Admin.aspx?module=san-pham&cat=qldm">Danh mục sản phẩm</a></li>
            <li><a href="Admin.aspx?module=san-pham&cat=qlnsp">Danh sách nhóm sản phẩm</a></li>
            <li><a href="Admin.aspx?module=san-pham&cat=qlsp">Danh sách sản phẩm</a></li>
        </ul>

        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a href="Admin.aspx?module=san-pham&cat=qldm&thaotac=them-moi">Danh mục sản phẩm</a></li>
            <li><a href="Admin.aspx?module=san-pham&cat=qlnsp&thaotac=them-moi">Nhóm sản phẩm</a></li>
            <li><a href="Admin.aspx?module=san-pham&cat=qlsp&thaotac=them-moi">Sản phẩm</a></li>
        </ul>
    </div>

    <div class="cotPhai">
        <asp:PlaceHolder ID="plSanPhamLoadControl" runat="server"></asp:PlaceHolder>
    </div>

    <div class="cb"></div>
</div>
