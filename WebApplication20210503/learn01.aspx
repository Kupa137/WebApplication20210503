<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="learn01.aspx.cs" Inherits="WebApplication20210503.learn01" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/0.jpg" OnClick="ImageButton1_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/2.jpg" OnClick="ImageButton2_Click" />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/5.jpg" OnClick="ImageButton3_Click" /><br>
    <asp:Label ID="Label1" runat="server" Text="玩家出:"></asp:Label>
    <br>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/0.jpg" />
    <br>
    <asp:Label ID="Label3" runat="server" Text="電腦出:"></asp:Label>
    <br><br>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <br>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>


</asp:Content>
