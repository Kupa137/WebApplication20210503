<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="learn02.aspx.cs" Inherits="WebApplication20210503.learn02" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Label ID="Label1" runat="server" Text="讀取次數"></asp:Label>
    <br />
    <form method="post" action="learn02.aspx">
        <input type="text" id="inp1" name="txtb1" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
    <br />
    <asp:Label ID="Label_t" runat="server" Text="count"></asp:Label>
    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>

</asp:Content>
