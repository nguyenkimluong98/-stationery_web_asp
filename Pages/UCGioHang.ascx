<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCGioHang.ascx.cs" Inherits="Pages_UCGioHang" %>

<div id="BangThongTinGioHang"></div>
<div style=" float: right; padding-right: 20px">
    <div class="total-price-modal" style="clear: both;">
        Tổng cộng : <span class="item-total TongTienTrongGioHang">0</span>VND
    </div>
</div>
<div style="clear:both;"></div>
<div class="KhungChuaBang">
    <div class="info-title">
        Thông tin giao hàng
    </div>
    <table class="tb-info" style="width: 100%">
        <tr>
            <td class="col1">Họ tên:</td>
            <td>
                <asp:TextBox ID="tbHoTen" CssClass="oNhap" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator  ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Bạn phải nhập họ tên" ControlToValidate="tbHoTen" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td class="col1">Số điện thoại:</td>
            <td>
                <asp:TextBox ID="tbSDT" CssClass="oNhap" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator2" runat="server" ErrorMessage="* SĐT không hợp lệ" ControlToValidate="tbSDT" Display="Dynamic" SetFocusOnError="True" ValidationExpression="(0\d{8,9})*" ForeColor="Red"  ></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Bạn phải nhập SDT" ControlToValidate="tbSDT" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="col1">Email:</td>
            <td>
                <asp:TextBox ID="tbEmail" CssClass="oNhap" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="col1">Địa chỉ nhận hàng:</td>
            <td>
                <asp:TextBox ID="tbDiaChi" CssClass="oNhap" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Bạn phải nhập địa chỉ" ControlToValidate="tbDiaChi" Display="Dynamic" SetFocusOnError="True" ForeColor="Red" ></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnDatHang" runat="server" Text="Đặt hàng" CssClass="btnDatHang" Font-Bold="True" ForeColor="#0099FF" Height="30px" Width="100px" OnClick="btnDatHang_Click"/>
            </td>
        </tr>
    </table>
</div>
<asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
<%--<table id="cart-table">
    <tbody>
        <tr>
            <th></th>
            <th>Tên sản phẩm</th>
            <th>Số lượng</th>
            <th>Đơn giá</th>
            <th></th>
        </tr>
        <%--<tr class="line-item original">
            <td class="item-image"></td>
            <td class="item-title">
                <a></a>
            </td>
            <td class="item-quantity"></td>
            <td class="item-price"></td>
            <td class="item-delete"></td>
        </tr>--%>
        <%--<tr class="line-item">
            <td class="item-image">
                <img class="anhSPGioHang" style="width: 100px;" src="../Images/but11.jpg" /></td>
            <td class="item-title">
                <a href="#"></a>
            </td>
            <td class="item-quantity">
                <asp:TextBox ID="TextBox1" AutoPostBack="True" runat="server" min="1" step="1" TextMode="Number"></asp:TextBox></td>
            <td class="item-price"></td>
            <td class="item-delete"><a href="#">Xóa</a></td>
        </tr>
    </tbody>
</table>--%>

<style>
.btnDatHang {
    display: block;
margin: auto;
}
.oNhap {
    width: 100%;
}
.info-title {
    padding: 5px;
    color: deepskyblue;
    font-size: 15px;
}
.tb-info .col1 {
    width: 30%;
}
#cart-table {
    border: 1px #d3d3d3 dotted;
}

#cart-table th {
    padding-bottom: 10px;
    padding-top: 10px;
    text-align: center;
}

th {
    font-size: 15px;
    color: #1C1C1C;
    font-weight: 600;
    
}
table tr td, table tr th {
    padding: 0px;
    border: 1px #d3d3d3 dotted;
}

table tr .item-stt {
    width: 30px;
}

table tr td, table tr th {
    padding: 10px;
    text-align: left;
}
table tr td {
    border-top: 1px solid #dddddd;
}
.item-price {
    font-size: 16px;
    width: 160px;
}

input[type=number]{
    width: 80px;
}

.item-quantity {
    width: 80px;
}

item-delete {
    position: relative;
    width: 40px;
}
.item-image, .item-quantity1, .item-delete {
    padding-top: 5px;
    padding-bottom: 5px;
}
td.item-image {
    width: 80px;
    text-align: center;
}
#cartform table .item-title {
    max-width: 200px !important;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap;
}
.item-title {
    width: 40%;
    /* color: #3399cc; */
    font-size: 14px;
}
.item-title a{text-decoration: none;
    outline: none;
    color: #b33551;}
td.item-title span {
    color: #000;
}
item input {
    width: 64px;
    text-align: center;
    height: 30px;
    border-radius: 3px;
    font-size: 14px;
    color: #808080;
    border: 1px solid #ccc;
    outline: none;
    padding-left: 15px;
}
.item-price {
    font-size: 13px;
    color: red;
    text-align: center;
}
.item-delete a {
    color: #000;
    top: 0;
    margin: auto;
    height: 19px;
    right: 0px;
    left: 0;
    bottom: 0;
    display: block;
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

<script>
    function LayThongTinGioHang() {
        $.post("XuLyGioHang.aspx",
            {
                "ThaoTac": "LayThongTinGioHang"
            },
            function (data, status) {
                $("#BangThongTinGioHang").html(data);
            });
    }

    function LayTongTienTrongGioHang() {
        $.post("XuLyGioHang.aspx",
            {
                "ThaoTac": "LayTongTienTrongGioHang"
            },
            function (data, status) {
                $(".TongTienTrongGioHang").html(data);
            });
    }

    function CapNhatSoLuongVaoGioHang(idSanPham) {

        var soLuongMoi = $("#quantity_" + idSanPham).val();

        $.post("XuLyGioHang.aspx",
            {
                "ThaoTac": "CapNhatSoLuongVaoGioHang",
                "idSanPham": idSanPham,
                "soLuongMoi": soLuongMoi
            },
            function (data, status) {
                if (data === "") {
                    LayTongTienTrongGioHang();
                }
            });
    }

    function XoaSPTrongGioHang(idSanPham) {
        if (confirm("Bạn muốn xóa sản phẩm này khỏi giỏ hàng?")) {

            $.post("XuLyGioHang.aspx",
                {
                    "ThaoTac": "XoaSPTrongGioHang",
                    "idSanPham": idSanPham
                },
                function (data, status) {
                    if (data === "") {
                        $("#tr_" + idSanPham).remove();
                        LayTongTienTrongGioHang();
                    }
                });
        }
    }

    $(document)
        .ready(function () {
            LayThongTinGioHang();
            LayTongTienTrongGioHang();
        });
</script>