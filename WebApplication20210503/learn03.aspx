<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="learn03.aspx.cs" Inherits="WebApplication20210503.learn03" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label2" runat="server" Text="超小聊天室，請用2個瀏覽器測試"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="使用者暱稱"></asp:Label>
    <asp:TextBox ID="userInput" runat="server"></asp:TextBox>
    <asp:Button ID="BtnUserName" runat="server" OnClick="BtnUserName_Click" Text="Button" />
    <br />
    <br/>

    <asp:Label ID="Label4" runat="server" Text="請輸入聊天內容:"></asp:Label>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
    </asp:Timer><%-- 似乎要用設計模式拉才會自動生成--%>
    

    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"><%--限制區域更新--%>
        <ContentTemplate><%-- 似乎要用設計模式拉才會自動生成--%>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
    

</asp:Content>
