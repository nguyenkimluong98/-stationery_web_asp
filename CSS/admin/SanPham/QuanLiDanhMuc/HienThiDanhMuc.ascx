<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiDanhMuc.ascx.cs" Inherits="CSS_admin_SanPham_QuanLiDanhMuc_HienThiDanhMuc" %>
<div class="head" style="color: black;">
    Các danh mục sản phẩm đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="Admin.aspx?module=san-pham&cat=qldm&thaotac=them-moi">Thêm mới danh mục</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên danh mục</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaDanhMuc(MaDM)
    {
        if(confirm("Bạn chắc chắn muốn xóa danh mục này"))
        {
            $.post("../CSS/admin/SanPham/QuanLiDanhMuc/DanhMuc.aspx",
                {
                    "ThaoTac":"XoaDanhMuc",
                    "MaDM": MaDM
                },
                function (data, status)
                {
                    if(data==1)
                    {
                        $("#maDong_" + MaDM).slideUp();

                    }
                });
        }
    }
</script>