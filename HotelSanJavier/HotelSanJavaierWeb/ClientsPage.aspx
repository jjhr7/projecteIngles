<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedMasterPage.Master" AutoEventWireup="true" CodeBehind="ClientsPage.aspx.cs" Inherits="HotelSanJavaierWeb.ClientsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style=" 
       margin-top: 5%;
       text-align-last: center;">
        <div>            
            <asp:Label class="nameClientText" ID="Label1" runat="server" Text="Label"></asp:Label>
            </br>
        </div>
        <div class="cointainer">
            <div class="row">
                <div class="offset-1 col-10">
                     <h2>List of reservations</h2>
                    <asp:Panel class="tableClients" ID="Panel1" runat="server"></asp:Panel>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
