<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiDanhSachNhomSanPham.ascx.cs" Inherits="CSS_admin_SanPham_QuanLiNhomSanPham_HienThiDanhSachNhomSanPham" %>
<div class="head" style="color: black;">
    Các nhóm sản phẩm đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="Admin.aspx?module=san-pham&cat=qlnsp&thaotac=them-moi">Thêm mới nhóm sản phẩm</a></div>
    
    <div class="fr ter"><p style="width: 50px"></p></div>
    <div class="fr ter marginRightHead">
        <div class="thongTinHeader">
            <div class="tenTruongHeader">Danh mục</div>
            <div class="oNhap">
                <asp:DropDownList ID="ddlDanhMucCha" AutoPostBack="True" runat="server" OnSelectedIndexChanged="ddlDanhMucCha_SelectedIndexChanged" Width="200px"></asp:DropDownList></div>
        </div>
    </div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbNhomSanPham">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên nhóm</th>
           <th class="cotTen">Tên danh mục</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrNhomSanPham" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaNhomSanPham(idNhom, idDM) {
        if (confirm("Bạn chắc chắn muốn xóa nhóm sản phẩn này")) {

            $.post("../CSS/admin/SanPham/QuanLiNhomSanPham/NhomSanPham.aspx",
                {
                    "ThaoTac": "XoaNhomSanPham",
                    "MaNhom": idNhom,
                    "MaDM": idDM
                },
                function (data, status) {

                    if (data == 1) {
                        
                        $("#maDong_" + idNhom + "_" + idDM).slideUp();

                    }
                });
        }
    }
</script>