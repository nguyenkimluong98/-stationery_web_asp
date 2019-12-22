<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChiTietDonHang.ascx.cs" Inherits="CSS_admin_DonHang_ChiTietDonHang" %>
<div class="container">
    <div style="clear: both; height: 20px;"></div>
    <div class="cotPhai" style="width: 100%;">
        <div class="head" style="color: black">
            Chi tiết đơn hàng
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
                    <asp:TextBox ID="tbTinhTrang" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="KhungChuaBang">
       <table class="tbDanhMuc" style="width: 60%; margin: auto">
           <tr>
               <th class="cotMa" style="width: 100px">Mã</th>
               <th class="cotTen">Tên sản phẩm</th>
               <th class="cotAnh">Ảnh đại diện</th>
               <th class="cotDonGia">Đơn Giá</th>
               <th class="cotCongCu">Số lượng</th>
               <th class="cotCongCu">Thành tiền</th>
           </tr>
           <asp:Literal ID="ltrSanPham" runat="server"></asp:Literal>
       </table>
            <div style="float: right; padding-right: 20px">
                <div class="total-price-modal" style="clear: both;">
                    <%--Tổng cộng : <span class="item-total TongTienTrongGioHang">0</span>VND--%>
            Tổng cộng :
                    <asp:Literal ID="ltrTongTien" runat="server"></asp:Literal>VND
                </div>
            </div>
    </div>
        
    </div>
    <div style="clear: both; height: 20px;"></div>
</div>

<style>
    .item-price {
    font-size: 13px;
    color: red;
    text-align: center;
}


.total-price-modal {
    text-align: right;
    margin-top: 20px;
    color: #808080;
}
.total-price-modal span {
    font-size: 20px;
    color: #303030;
    vertical-align: middle;
}
</style>