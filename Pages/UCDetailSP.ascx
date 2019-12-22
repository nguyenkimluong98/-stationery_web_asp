<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCDetailSP.ascx.cs" Inherits="Pages_UCDetailSP" %>
<asp:Literal ID="ltrLink" runat="server"></asp:Literal>

<div class="detail-product">
    <div class="product-info-top">
        <div class="product-info-img">
            <div class="large-thumb">
                <div class="zoomPad">
                    <%--<img src="../Images/but11.jpg" class="thumb_goc" style="opacity: 1;"/>--%>
                    <asp:Literal ID="ltrBigImg" runat="server"></asp:Literal>
                    <div class="zoomPup" style="top: -1px; left: -1px; width: 338px; height: 320px; position: absolute; border-width: 1px; opacity: 1;">
                        <%--<img src="../Images/but11.jpg" style="position: absolute; display: block; left: 0px; top: 0px;">--%>
                        <asp:Literal ID="ltrZoomUp" runat="server"></asp:Literal>
                    </div>
                    <div class="zoomWindow" style="position: absolute; left: 338px; top: 0px;">
                        <div class="zoomWrapper" style="width: 400px;">
                            <div class="zoomWrapperTitle" style="width: 100%; position: absolute; display: block;">Phong bì trắng khổ a4</div>
                            <div class="zoomWrapperImage" style="width: 100%; height: 424px;">
                                <%--<img src="../Images/but11.jpg" style="position: absolute; border: 0px; display: block; left: 0px; top: 0px;">--%>
                                <asp:Literal ID="ltrZoomWin" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="more-thumb">
               <%--<img src="../Images/but11.jpg">--%>
                <asp:Literal ID="ltrSmallImg" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="product-info-cont">
            <%--<h1>Phong bì trắng khổ a4</h1>--%>
            <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
            <div class="tahoma">Mã sản phẩm: <span class="price bold">
                <asp:Literal ID="ltrMa" runat="server"></asp:Literal></span></div>
            <div class="tahoma light-blue bold">Giá: <span class="price">
                <asp:Literal ID="ltrGia" runat="server"></asp:Literal></span></div>
            <div class="arial">
            </div>
            <div class="call-to-order">
                <div>
                    <div>Gọi ngay !</div>
                    <div class="phone">
                        <a href="tel:0969410002">0969 318 982</a>
                    </div>
                    <div class="phone">
                        <a href="tel:0969318982">0969 410 002</a>
                    </div>
                </div>
            </div>
            <div class="nutGioHangBox">
                <asp:LinkButton ID="btnThem" runat="server" CssClass="themVaoGio" BackColor="Red" OnClick="btnThem_Click">
                    <p>Thêm vào giỏ</p>
                </asp:LinkButton>
                <asp:LinkButton ID="btnMuaNgay" runat="server" CssClass="muaNgay" BackColor="Orange" OnClick="btnMuaNgay_Click">
                    <p>Mua ngay</p>
                </asp:LinkButton>
                <div style="clear: both"></div>
                
            </div>
            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
        </div>
        <div style="clear: both"></div>
    </div>
    <div class="clear"></div>
    <div class="product-info-top">
        <ul class="tab">
            <li><a href="#" class="menu-tab active" rel="single-product-tabs">Chi tiết sản phẩm</a></li>
            <li><a href="#" class="menu-tab" rel="single-product-tabs">Bình luận</a></li>
        </ul>
        <div class="tab-cont content_tab single-product-tabs" style="display: block;">
            <asp:Literal ID="ltrMota" runat="server"></asp:Literal>
        </div>
        <div class="tab-cont content_tab single-product-tabs">
            
        </div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3>Sản phẩm bán chạy</h3>
    </div>

    <div>
        <asp:Literal ID="ltrTop" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>

<div class="box-category">
    <div class="title-bar">
        <h3>Các sản phẩm khác</h3>
    </div>

    <div>
        <asp:Literal ID="ltrSameSP" runat="server"></asp:Literal>
        <div style="clear: both"></div>
    </div>
</div>

<style>


img {
    object-fit: cover;
    border: 0;
    vertical-align: middle;
}

.detail-product {
    border: 1px #dfdfdf solid;
    padding: 10px;
    width: 100%;
}

.product-info-top {
    margin-bottom: 10px;
}

.product-info-img {
    float: left;
    width: 340px;
}

.product-info-img .large-thumb {
    width: 100%;
    height: 322px;
    border: 1px #d9d9d9 solid;
    display: block;
    text-align: center;
}

.zoomPad {
    position: relative;
    float: left;
    cursor: crosshair;
}

.product-info-img .large-thumb img.thumb_goc, .zoomPup img {
    width: 100%;
    max-height: 320px;
    margin: 0 auto;
}


.zoomPup {
    background-color: #fff;
    opacity: .6;
    position: absolute;
    border: 1px solid #ccc;
    cursor: crosshair;
    display: none;
}

.product-info-img .large-thumb img.thumb_goc, .zoomPup img {
    width: 100%;
    max-height: 320px;
    margin: 0 auto;
}

.zoomWindow {
    position: absolute;
    left: 110%;
    top: 40px;
    background: #fff;
    height: auto;
    display: none;
}


.zoomPreload {
    opacity: .8;
    color: #333;
    font-size: 12px;
    font-family: Tahoma;
    text-decoration: none;
    border: 1px solid #ccc;
    background-color: #fff;
    padding: 8px;
    text-align: center;
    background-image: url(../images/zoomloader.gif);
    background-repeat: no-repeat;
    background-position: 43px 30px;
    width: 90px;
    height: 43px;
    position: absolute;
    top: 0;
    left: 0;
}

.zoomPad:hover .zoomWindow {
    display: block;
}


.product-info-img .more-thumb {
    margin-top: 10px;
}

.product-info-img .more-thumb img {
    width: 58px;
    height: 58px;
    border: 1px #d9d9d9 solid;
    float: left;
    margin-right: 6px;
}

.product-info-cont {
    margin-top: 0;
    width: calc(100% - 340px);
    display: block;
    float: left;
    border: 1px #d3d3d3 dashed;
    padding: 8px;
    color: #676767;
}

.product-info-cont h1 {
    display: block;
    color: #217fbc;
    font-size: 18px;
    font-family: Arial;
    margin-bottom: 18px;
    text-align: left;
}

.product-info-cont>div {
    display: block;
    padding-bottom: 8px;
    line-height: 18px;
}

.tahoma {
    font-family: tahoma;
}

.bold {
    font-weight: 700;
}

.light-blue {
    color: #217fbc;
}

.arial {
    font-family: arial;
}

.product-info-cont .call-to-order {
    padding: 10px;
    text-align: center;
    color: #c61b1b;
    text-transform: uppercase;
    font-weight: 700;
    font-size: 14px;
    border: 1px #d3d3d3 dotted;
    width: 100%;
    display: inline-block;
}

.product-info-cont .phone a {
    color: red;
}

.product-info-cont .call-to-order .phone {
    font-size: 24px;
    margin-top: 10px;
    width: 100%;
}

.product-info-cont .phone {
    display: block;
    float: left;
    width: 100%;
}

.clear {
    clear: both;
}

a {
    text-decoration: none;
    outline: 0;
}

.product-info-top .tab {
    margin-top: 20px;
    height: 29px;
    position: relative;
    margin-bottom: 0;
    padding: 0px;
}

ol, ul {
    margin-top: 0;
    margin-bottom: 10px;
}

.product-info-top .tab li {
    float: left;
    display: block;
}

.product-info-top .tab li a {
    text-transform: uppercase;
    font-size: 12px;
    font-family: tahoma;
    padding: 6px 12px;
    display: block;
    float: left;
    color: #676767;
}

.product-info-top .tab li a.active, .product-info-top .tab li a:hover {
    background: #d9d9d9;
    border-right: 1px #e6e6e6 solid;
    font-weight: 700;
    position: relative;
    margin-bottom: -1px;
    color: #333;
}

.product-info-top .tab-cont {
    border: 1px #d9d9d9 solid;
    padding: 10px;
    line-height: 18px;
}

.content_tab {
    display: none;
}
</style>