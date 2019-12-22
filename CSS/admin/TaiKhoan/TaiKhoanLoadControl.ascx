<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoanLoadControl.ascx.cs" Inherits="CSS_admin_TaiKhoan_TaiKhoanLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a href="Admin.aspx?module=tai-khoan">Danh sách tài khoản</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a href="Admin.aspx?module=tai-khoan&thaotac=them-moi">Danh sách tài khoản</a></li>            
        </ul>
    </div>
    <div class="cotPhai">
      
        <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>
