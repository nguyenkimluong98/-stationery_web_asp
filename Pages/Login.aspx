<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang đăng nhập vào khu vực quản trị website</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="FormDangNhap">
        <div class="head">Đăng nhập hệ thống</div>
        <div class="controls">
            <div class="row">
            <div class="left">Tên đăng nhập</div>
            <div class="right">
                <asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" 
                    ControlToValidate="tbTenDangNhap" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>            
        </div>
        <div class="row">
            <div class="left">Mật khẩu</div>
            <div class="right">
                <asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="*" SetFocusOnError="True" Display="Dynamic" 
                    ControlToValidate="tbMatKhau" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>            
        </div>
        <div class="row">
            <div class="left">&nbsp;</div>
            <div class="right">
                <asp:LinkButton ID="lbtDangNhap" runat="server" CssClass="btDangNhap" OnClick="lbtDangNhap_Click">Đăng nhập</asp:LinkButton>
            </div>            
        </div>
        <div>
            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
        </div>
        </div>
    </div>
    </form>
</body>
</html>

<style>
body {font:normal 12px Arial;color:#333;;margin:0px;padding:0px}
*{box-sizing:border-box}
.FormDangNhap{width:400px;margin:auto;margin-top:100px}
.head{font-weight:bold; padding:12px 20px; background:deepskyblue;text-align:center;color:#fff;font-size:14px}
.controls{border:solid 1px #dfdfdf;border-top:none;padding:20PX}
.row{overflow:hidden;padding-bottom:10px}
.left{float:left; width:120px}
.right{float:left; width:calc(100% - 120px)}
.right input[type=text],
.right input[type=password]{border:solid 1px #dfdfdf; width:96% ;padding:5px}
.btDangNhap{border:0 ;background:deepskyblue;cursor:pointer;padding:10px 20px;color:#fff;font-weight:bold;text-decoration:none; display:inline-block}
.ThongBao{color:red;font-weight:bold;text-align:center;padding-top:10px}
</style>


