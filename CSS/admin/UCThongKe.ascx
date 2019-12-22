<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UCThongKe.ascx.cs" Inherits="CSS_admin_UCThongKe" %>
<div style="padding: 30px">
    <div style="display: block; font-size: 15px; color: brown; font-weight: 700; margin-bottom: 15px;">Tổng số:</div> 
    <asp:Label ID="Label1" runat="server" Text=""><%=Application["DaTruyCap"].ToString()%></asp:Label> lượt truy cập

    <div style="display: block; font-size: 15px; color: brown; font-weight: 700; margin-bottom: 15px; margin-top: 30px;">Đang online:</div> 
    <asp:Label ID="lblCount" runat="server" Text=""><%=Application["DangOnline"].ToString()%></asp:Label> đang online
</div>
