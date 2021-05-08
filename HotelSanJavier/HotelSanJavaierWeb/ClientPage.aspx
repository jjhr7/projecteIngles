<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientPage.aspx.cs" Inherits="HotelSanJavaierWeb.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="cointainer">
            <div class="row">
                <div class="offset-1 col-10">
                    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
