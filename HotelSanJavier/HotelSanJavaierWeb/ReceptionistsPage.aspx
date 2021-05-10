<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ReceptionistsPage.aspx.cs" Inherits="HotelSanJavaierWeb.ReceptionistsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Label1" runat="server" Text="" style="margin-top: 5%; text-align-last: center"></asp:Label>
            <asp:Panel ID="Panel3" runat="server"></asp:Panel>
            <div class="offset-1 col-10">
                <h2>List of reserves</h2>
                <asp:Panel class="tableClients" ID="Panel1" runat="server"></asp:Panel>
            </div>
            <div class="offset-1 col-10">
                <h2>List of clients</h2>
                <asp:Panel class="tableClients" ID="Panel2" runat="server"></asp:Panel>
            </div>
            <div class="offset-1 col-10"> 
                <asp:Panel class="tableClients" ID="Panel4" runat="server"></asp:Panel>
            </div>
            <form id="form1" runat="server" style="margin-bottom: 10%; background-color: rgba(0,0,0,0.3);">
                <div class="row" style="text-align: justify;">
                    <div class="col-4" style="text-align: -webkit-center;">
                        <h2>Create client form</h2>
                        <asp:TextBox ID="dniClientC" runat="server" placeholder="DNI"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="passwowrdClicentC" runat="server" placeholder="Password"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="telephoneClientC" runat="server" placeholder="Telephone"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="clientNameC" runat="server" placeholder="Name"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="surnameClientC" runat="server" placeholder="Surname"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="emailClientC" runat="server" placeholder="E-mail"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button3" runat="server" Text="Create client" OnClick="Button3_Click" />
                    </div>
                    <div class="col-4" style="text-align: -webkit-center;">
                        <h2>Create receptionist form</h2>
                        <asp:TextBox ID="nameReceptionist" runat="server" placeholder="Name"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="lasnameReceptionist" runat="server" placeholder="Surname"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="dniReceptionist" runat="server" placeholder="DNI"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="rolReceptionist" runat="server" placeholder="Rol"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="passwordReceptionist" runat="server" placeholder="Password"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Create receptionist" OnClick="Button1_Click" />
                    </div>
                    <div class="col-4" style="text-align: -webkit-center;">
                        <h2>Create reservation form</h2>
                        <asp:TextBox ID="dni_client" runat="server" placeholder="DNI client"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="entry_date" runat="server" placeholder="Entry date (DD-MM-AAA)"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="exit_date" runat="server" placeholder="Exit date (DD-MM-AAA)"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="TextBox5" runat="server" placeholder="ID room"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" Text="Create reserve" OnClick="Button2_Click" />
                    </div>
                </div>

            </form>
        </div>
    </div>
</asp:Content>
