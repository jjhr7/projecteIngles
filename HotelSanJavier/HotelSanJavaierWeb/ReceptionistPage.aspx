<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceptionistPage.aspx.cs" Inherits="HotelSanJavaierWeb.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <div class="row">
             <asp:Label ID="Label1" runat="server" Text="Label">Id recepcionista: </asp:Label>
            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
            <form id="form1" runat="server">
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Label">Name recepcionist: </asp:Label>
                    <asp:TextBox ID="nameReceptionist" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Label">last name recepcionist: </asp:Label>
                    <asp:TextBox ID="lasnameReceptionist" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Label">DNI: </asp:Label>
                    <asp:TextBox ID="dniReceptionist" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Label">Rol: </asp:Label>
                    <asp:TextBox ID="rolReceptionist" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Label">Password: </asp:Label>
                    <asp:TextBox ID="passwordReceptionist" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </form>
        </div>
    </div>
</body>
</html>
