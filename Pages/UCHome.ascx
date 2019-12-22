<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCHome.ascx.cs" Inherits="Pages_UCHome" %>
<link href="../font-awesome/css/font-awesome.css" rel="stylesheet" />
<link href="../CSS/Style.css" rel="stylesheet" />

<div class="slide">
		<div class="dieuhuong">
			<i class="fa fa-chevron-circle-left" onclick="Back();"></i>
			<i class="fa fa-chevron-circle-right" onclick="Next();"></i>
		</div>
		<div class="chuyen-slide">
			<img src="../Images/anhslide1.jpg">
			<img src="../Images/anhslide2.jpg">
			<img src="../Images/anhslide3.jpg">
		</div>
	</div>

<%--<div class="head">
    <div style="float: right;float: right; color: deepskyblue; font-size: 16px;">Các danh mục sản phẩm đã tạo. </div>
    <div style="clear: both"></div>
</div>--%>

<div class="box-category">
    <div class="title-bar">
        <h3>Sản phẩm bán chạy</h3>
    </div>

    <div>
        <asp:Literal ID="ltrTop" runat="server"></asp:Literal>
        <%--<div class="khungchuasp">
            <div class="zoom"></div>
            <div class="tensp"><a href="#">Tên sản phẩm</a></div>
            <div class="giaban">Giá bán</div>
        </div>--%>
        <div style="clear: both"></div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3><asp:Label ID="lblBut" runat="server" Text="Label"></asp:Label></h3>
        <a class="fr block text-right light-blue" href="Home.aspx?type=main&dm=1">Xem thêm »</a>
    </div>

    <div>
        <asp:Literal ID="ltrBut" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3><asp:Label ID="lblDungCu" runat="server" Text="Label"></asp:Label></h3>
        <a class="fr block text-right light-blue" href="Home.aspx?type=main&dm=2">Xem thêm »</a>
    </div>

    <div>
        <asp:Literal ID="ltrDungCu" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3><asp:Label ID="lblTapHoa" runat="server" Text="Label"></asp:Label></h3>
        <a class="fr block text-right light-blue" href="Home.aspx?type=main&dm=7">Xem thêm »</a>
    </div>

    <div>
        <asp:Literal ID="ltrTapHoa" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3><asp:Label ID="lblGiay" runat="server" Text="Label"></asp:Label></h3>
        <a class="fr block text-right light-blue" href="Home.aspx?type=main&dm=4">Xem thêm »</a>
    </div>

    <div>
        <asp:Literal ID="ltrGiay" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3><asp:Label ID="lblSo" runat="server" Text="Label"></asp:Label></h3>
        <a class="fr block text-right light-blue" href="Home.aspx?type=main&dm=6">Xem thêm »</a>
    </div>

    <div>
        <asp:Literal ID="ltrSo" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>



<script type="text/javascript" src="../CSS/slide.js"></script>