<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HienThiTaiKhoan.ascx.cs" Inherits="CSS_admin_TaiKhoan_HienThiTaiKhoan" %>
<div>
    <div class="head" style="color: black;">
    Danh sách tài khoản đã tạo 
    <div class="fr ter"><a class="btThemMoi" href="Admin.aspx?module=tai-khoan&thaotac=them-moi">Thêm tài khoản mới</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotTenDK">Tên đăng nhập</th>
           <th class="cotHoTen">Họ tên</th>
           <th class="cotNgaySinh">Ngày sinh</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrTaiKhoan" runat="server"></asp:Literal>
   </table>
</div>
</div>

<script type="text/javascript">
    function XoaTaiKhoan(TenDangNhap) {
        if (confirm("Bạn chắc chắn muốn xóa tài khoản này")) {

            $.post("../CSS/admin/TaiKhoan/TaiKhoan.aspx",
                {
                    "ThaoTac": "XoaTaiKhoan",
                    "TenDangNhap": TenDangNhap
                },
                function (data, status) {
                    if (data == 1) {

                        $("#maDong_" + TenDangNhap).slideUp();
                    }

                    else
                    {
                        alert(data);
                    }
                });
        }
    }
</script>
