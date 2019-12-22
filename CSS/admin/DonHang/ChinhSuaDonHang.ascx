<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChinhSuaDonHang.ascx.cs" Inherits="CSS_admin_DonHang_ChinhSuaDonHang" %>
<div class="container">
    <div style="clear: both; height: 20px;"></div>
    <div class="cotPhai" style="width: 100%;">
        <div class="head" style="color: black">
            Chỉnh sửa đơn hàng
        </div>
        <div class="FormThemMoi" style="margin: auto auto; width: 80%; margin-left: 30%">
            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
            <div class="thongTin">
                <div class="tenTruong">Mã đơn hàng</div>
                <div class="oNhap">
                    <asp:TextBox ID="tbMaDH" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">Họ tên</div>
                <div class="oNhap">
                    <asp:TextBox ID="tbHoTen" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">Số điện thoại</div>
                <div class="oNhap">
                    <asp:TextBox ID="tbSDT" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">Email</div>
                <div class="oNhap">
                    <asp:TextBox ID="tbEmail" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">Địa chỉ</div>
                <div class="oNhap">
                    <asp:TextBox ID="tbDiaChi" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">Ngày đặt</div>
                <div class="oNhap">
                    <asp:TextBox ID="tbNgayDat" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">Tình trạng</div>
                <div class="oNhap">
                    <asp:DropDownList ID="dlTinhTrang" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="thongTin">
                <div class="tenTruong">&nbsp;</div>
                <div class="oNhap">
                    <asp:Button ID="btChinhSua" runat="server" Text="Chỉnh sửa" CssClass="btThemMoi" OnClick="btChinhSua_Click" />
                    <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" OnClick="btHuy_Click" CausesValidation="false" />
                </div>
            </div>
        </div>
    </div>
    <div style="clear: both; height: 20px;"></div>
</div>

