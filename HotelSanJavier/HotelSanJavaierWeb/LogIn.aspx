<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HotelSanJavaierWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
</head>
<body>
    <div class="container">
       

           <form id="formClients" runat="server">
               <div class="row">
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
                 </div>
            </form>
       </div>
    
</body>
</html>
