<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="learn04.aspx.cs" Inherits="WebApplication20210503.learn04" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
        <input name="in1" />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
  






<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AccountConnectionString %>" SelectCommand="SELECT * FROM [users]"></asp:SqlDataSource>
  

        <div>用SQL的資料登入測試
            <br />
            <asp:Label ID="Label3" runat="server" Text="username"></asp:Label>
            <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="password"></asp:Label>
            <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="login" />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

        </div>
        <br />
        <div>資料寫入SQL測試
            <br />
            <asp:Label ID="Label5" runat="server" Text="username"></asp:Label>
            <asp:TextBox ID="txtInputUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="password"></asp:Label>
            <asp:TextBox ID="txtInputPassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnNewAccount" runat="server" Text="寫入" OnClick="btnNewAccount_Click" />
        </div>

  

</asp:Content>
