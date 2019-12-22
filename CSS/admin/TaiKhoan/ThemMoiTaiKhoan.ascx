<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiTaiKhoan.ascx.cs" Inherits="CSS_admin_TaiKhoan_ThemMoiTaiKhoan" %>
<div class="head">
    Thêm mới, chỉnh sửa tài khoản
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>  
    <div class="thongTin">
        <div class="tenTruong">Tên đăng nhập</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenDangNhap" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Bạn phải điền tên đăng nhập" ControlToValidate="tbTenDangNhap" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Mật khẩu</div>
        <div class="oNhap"> 
            <asp:HiddenField ID="hdMatKhauCu" runat="server" />           
            <asp:TextBox ID="tbMatKhau" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Bạn phải nhập mật khẩu" ControlToValidate="tbMatKhau" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Họ tên</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbHoTen" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">Ngày sinh (Tháng/Ngày/Năm)</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbNgaySinh" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" SetFocusOnError="true" ForeColor="Red" ValidationExpression="^([0-2][0-9]||3[0-1])/(0[0-9]||1[0-2])/([0-9][0-9])?[0-9][0-9]$" runat="server" ErrorMessage="* Ngày sinh: dd/MM/yyyy" ControlToValidate="tbNgaySinh"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="thongTin">
        <div class="tenTruong">&nbsp;</div>
        <div class="oNhap">
            <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
            <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
        </div>
    </div>
</div>