<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedMasterPage.Master" AutoEventWireup="true" CodeBehind="ReceptionistsPage.aspx.cs" Inherits="HotelSanJavaierWeb.ReceptionistsPage" %>

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
                        <asp:Button ID="Button3" runat="server" type="button" class="btn btn-success" Text="Create client" OnClick="Button3_Click" />
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
                        <asp:Button ID="Button1" runat="server" type="button" class="btn btn-success" Text="Create receptionist" OnClick="Button1_Click" />
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
                        <asp:Button ID="Button2" runat="server" type="button" class="btn btn-success" Text="Create reserve" OnClick="Button2_Click" />
                    </div>
                </div>
                <div class="row ">
                    <h3 class="d-flex justify-content-center">Edit actions</h3>
                    <div class="offset-1 col-10 ">
                        <asp:Button ID="EditReservation" class="btn btn-info" runat="server" Text="Edit reservation" OnClick="EditReservatio_Click" />
                        <br />
                        <asp:TextBox ID="idReservationEdit" runat="server" placeholder="Id reservation to edit" Visible="False"></asp:TextBox>
                       <br />
                        <asp:Button ID="findDataToEdit" class="btn btn-info" Visible="False" runat="server" Text="Fetch reservation Data" OnClick="findDataToEdit_Click" />
                        <br />
                        <asp:TextBox ID="dniClientEdit" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="idReceptionistEdit" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="entryDateEdit" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="exitDateEdit" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="idRoomEdit" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:Button ID="ApplyEdit" class="btn btn-info" runat="server" Text="Apply Reservation data edited" Visible="False" OnClick="ApplyEdit_Click" />
                        <br />
                    </div>
                    <div class="offset-1 col-10  ">
                        <asp:Button ID="EditClient" class="btn btn-info" runat="server" Text="Edit client" OnClick="EditClient_Click" />
                        <br />
                        <asp:TextBox ID="dniClientUpdate" runat="server" placeholder="Type the DNI client to edit" Visible="False"></asp:TextBox>
                       <br />
                        <asp:Button ID="findClientUpdate" class="btn btn-info" Visible="False" runat="server" Text="Fetch client Data" OnClick="Button4_Click"  />
                        <br />
                        <asp:TextBox ID="passwordClientUpdate" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="telephoneClientUpdate" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="nameClietnUpdate" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="surnameClientUpdate" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="emailClientUpdate" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="idReceptionistClientUpdate" runat="server" Visible="false"></asp:TextBox>
                        <br />
                        <asp:Button ID="ApplyClientUpdate" class="btn btn-info" runat="server" Text="Apply client data edited" Visible="False" OnClick="ApplyClientUpdate_Click"  />
                    </div>
                    <div class="col-4 ">
                        <asp:Button ID="EditReceptionist" class="btn btn-info" runat="server" Text="Edit receptionist" Visible="false" OnClick="EditReceptionist_Click" />
                        
                    </div>
               </div>
                <div class="row">
                    <div class="offset-1 col-10"></div>
                    <asp:Button class="col-4 btn btn-success" Text="Download reservations" runat="server" ID="jsonReservations" OnClick="Unnamed1_Click" type="button"/>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
