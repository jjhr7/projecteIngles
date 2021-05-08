<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientPage.aspx.cs" Inherits="HotelSanJavaierWeb.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="row">
            <div class="col-10">
                <table class="table" id="listReservations">
                  <thead class="thead-light">
                    <tr>
                      <th scope="col">ID RESERVATION</th>
                      <th scope="col">DNI CLIETN</th>
                      <th scope="col">ID RECEPCIONISTS</th>
                      <th scope="col">ENTRY DATE</th>
                      <th scope="col">EXIT DATE</th>
                      <th scope="col">ID ROOM</th>
                    </tr>
                  </thead>
                  <tbody id="reservationsData">
                    
                    <tr>
                      <th scope="row">2</th>
                      <td>Jacob</td>
                      <td>Thornton</td>
                      <td>@fat</td>
                    </tr>
                    <tr>
                      <th scope="row">3</th>
                      <td>Larry</td>
                      <td>the Bird</td>
                      <td>@twitter</td>
                    </tr>
                  </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
