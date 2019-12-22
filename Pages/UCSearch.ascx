<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCSearch.ascx.cs" Inherits="Pages_UCSearch" %>

<div class="main-leftt box-content">
    <div class="box box-content">
        <asp:Literal ID="ltrTitle" runat="server"></asp:Literal>
        <div>
            <ul class="list-item-category">
                <asp:Literal ID="ltrSanPham" runat="server"></asp:Literal>
            </ul>
        </div>
    </div>
</div>

<style>
div {
    display: block;
}

.main-leftt {
    float: left;
    width: calc(100%);
}

.main-leftt.box-content {
    border: 1px #dfdfdf solid;
    width: 100%;
}

.box.box-content {
    padding: 10px 10px 20px;
}

h1.bar {
    font-size: 15px;
}

h1.bar, h3.bar {
    text-transform: uppercase;
    color: #217fbc;
    padding-left: 5px;
    margin-bottom: 10px;
    border-left: 5px #217fbc solid;
    line-height: 13px;
}

h1 {
    font: bold 36px/100% "trebuchet ms",tahoma,arial;
    margin: 0;
    padding-bottom: 3px;
    text-align: right;
}

ol, ul {
    margin-top: 0;
    margin-bottom: 10px;
    padding: 0;
}

ul {
    display: block;
    list-style-type: none;
}

.list-item-category li {
    display: block;
    padding: 10px 0;
    border-bottom: 1px #876464 dotted;
}

li {
    display: list-item;
}

.list-item-category li .pic {
    float: left;
    margin-top: 5px;
    width: 134px;
}

.title > a {
    text-decoration: none;
    outline: 0;
    color: #217fbc;
    font-size: 12px;
    font-family: tahoma;
    font-weight: 700;
    background-color: transparent;
}

.list-item-category li .cont {
    margin-left: 134px;
}

.list-item-category li .cont .title {
    padding-bottom: 4px;
}

.cont .title a {
    color: #217fbc;
    font-size: 12px;
    font-family: tahoma;
    font-weight: 700;
}

.cont .des {
    font-family: tahoma;
    font-size: 12px;
    color: #464646;
}

.clear {
    clear: both;
}

.price {
    color: red;
    font-size: 13px;
}
</style>