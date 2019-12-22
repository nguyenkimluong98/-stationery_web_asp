<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiDonHang.ascx.cs" Inherits="CSS_admin_DonHang_HienThiDonHang" %>
<div class="container">
    <div style="clear: both; height: 20px;"></div>
    <div class="cotPhai" style="width: 100%;">
        <div class="head" style="color: black;">
            Danh sách đơn hàng
            <div class="cb"></div>
        </div>
        <div class="KhungChuaBang">
            <table class="tbDanhMuc">
                <tr>
                    <th class="cotMa">Mã DH</th>
                    <th class="cotHoTen">Họ tên</th>
                    <th class="cotTenDK">Số điện thoại</th>
                    <th class="cotHoTen">Email</th>
                    <th class="cotDiaChi">Địa chỉ</th>
                    <th class="cotNgaySinh">Ngày đặt</th>
                    <th class="cotHoTen">Tình trạng</th>
                    <th class="cotCongCu">Công cụ</th>
                </tr>
                <asp:Literal ID="ltrDonHang" runat="server"></asp:Literal>
            </table>
        </div>
    </div>
    <div style="clear:both; height: 20px;"></div>
</div>

<style>
.cotMa {
    width: 30px;
    text-align: center;
}

.cotHoTen {
    width: 100px;
    text-align: center;
}

.cotDiaChi {
    width: 400px;
    text-align: center;
}
</style>

<script type="text/javascript">
    function XoaDonHang(MaDH) {
        if (confirm("Bạn chắc chắn muốn xóa đơn hàng này")) {

            $.post("../CSS/admin/DonHang/DonHang.aspx",
                {
                    "ThaoTac": "XoaDonHang",
                    "MaDH": MaDH
                },
                function (data, status) {
                    if (data == 1) {

                        $("#maDong_" + MaDH).slideUp();
                    }

                    else
                    {
                        alert(data);
                    }
                });
        }
    }
</script>
