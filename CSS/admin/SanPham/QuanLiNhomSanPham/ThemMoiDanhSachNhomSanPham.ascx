<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemMoiDanhSachNhomSanPham.ascx.cs" Inherits="CSS_admin_SanPham_QuanLiNhomSanPham_ThemMoiDanhSachNhomSanPham" %>
<div class="head">
    Thêm mới, chỉnh sửa nhóm sản phẩm
</div>
<div class="FormThemMoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tenTruong">Danh mục cha</div>
        <div class="oNhap"><asp:DropDownList ID="ddlDanhMuc" AutoPostBack="True" runat="server"></asp:DropDownList></div>
    </div>   
    <div class="thongTin">
        <div class="tenTruong">Tên nhóm sản phẩm</div>
        <div class="oNhap">            
            <asp:TextBox ID="tbTenNhomSanPham" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbTenNhomSanPham" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
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