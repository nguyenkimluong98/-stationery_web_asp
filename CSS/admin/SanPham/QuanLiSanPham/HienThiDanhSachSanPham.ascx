<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiDanhSachSanPham.ascx.cs" Inherits="CSS_admin_SanPham_QuanLiSanPham_HienThiDanhSachSanPham" %>
<div class="head" style="color: black;">
    Các sản phẩm đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="Admin.aspx?module=san-pham&cat=qlsp&thaotac=them-moi">Thêm mới sản phẩm</a></div>
    
    <div class="fr ter"><p style="width: 50px"></p></div>
    <div class="fr ter marginRightHead">
        <div class="thongTinHeader">
            <div class="tenTruongHeader">Nhóm sản phẩm</div>
            <div class="oNhap">
                <asp:DropDownList ID="ddlNhomSP" AutoPostBack="True" runat="server" Width="200px" OnSelectedIndexChanged="ddlNhomSP_SelectedIndexChanged"></asp:DropDownList></div>
        </div>
    </div>
    <div class="fr ter"><p style="width: 50px"></p></div>
    <div class="fr ter marginRightHead">
        <div class="thongTinHeader">
            <div class="tenTruongHeader">Danh mục</div>
            <div class="oNhap">
                <asp:DropDownList ID="ddlDanhMucCha" AutoPostBack="True" runat="server" Width="200px" OnSelectedIndexChanged="ddlDanhMucCha_SelectedIndexChanged"></asp:DropDownList></div>
        </div>
    </div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên sản phẩm</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotDonGia">Đơn Giá</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrSanPham" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaSanPham(MaSP) {
        if (confirm("Bạn chắc chắn muốn xóa sản phẩm này")) {

            $.post("../CSS/admin/SanPham/QuanLiSanPham/SanPham.aspx",
                {
                    "ThaoTac": "XoaSanPham",
                    "MaSP": MaSP
                },
                function (data, status) {

                    if (data == 1) {

                        $("#maDong_" + MaSP).slideUp();

                    }
                });
        }
    }
</script>