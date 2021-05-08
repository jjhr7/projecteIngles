<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HotelSanJavaierWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="row">

       <form id="formClients" runat="server">

        <div class="col-6">
            
        <div>
            <asp:TextBox ID="dniClient" runat="server"></asp:TextBox>
            <asp:TextBox ID="passwordClient" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    
        </div>

        <div class="col-6">
            <div>
                <asp:TextBox ID="dniRecepcionist" runat="server"></asp:TextBox>
                <asp:TextBox ID="passwordRecepcionist" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
            </div>
            <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
    
        </div>
        </form>
   </div>
    
</body>
</html>
