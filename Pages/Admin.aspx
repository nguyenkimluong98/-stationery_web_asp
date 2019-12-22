<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Pages_Admin" %>

<%@ Register Src="~/CSS/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quản trị</title>
    <link href="../CSS/admin/styles.css" rel="stylesheet" />
    <script src="../CSS/bootstrap-3.3.7-dist/js/jquery-1.8.3.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <div class="container">
                <div class="accountMenu">
                        Xin chào:<asp:Literal ID="ltrTenDangNhap" runat="server"></asp:Literal> | <asp:LinkButton ID="lbtDangXuat" runat="server" OnClick="lbtDangXuat_Click">Đăng xuất</asp:LinkButton>
                    </div>        
            </div>
        </div>

        <div class="MenuChinh">
            <div class="container">
                <ul>
                    <li><a href="Admin.aspx" title="Trang chủ">Trang chủ</a></li>
                    <li><a href="Admin.aspx?module=san-pham" title="Sản phẩm">Sản phẩm</a></li>
                    <li><a href="Admin.aspx?module=don-dat-hang" title="Đơn đặt hàng">Đơn đặt hàng</a></li>
                    <li><a href="Admin.aspx?module=tai-khoan" title="Tài khoản">Tài khoản</a></li>
                </ul>
            </div>
        </div>

        <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
    </form>
</body>
</html>
