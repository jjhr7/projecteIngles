<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="HotelSanJavaierWeb.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Background image -->
    <div
        class="divImg p-5 text-center bg-image"
        style="background-image: url('https://mdbcdn.b-cdn.net/img/new/slides/041.jpg'); background-repeat: no-repeat; background-size: cover; width: 100%; height: auto;">
        <div class="mask" style="background-color: rgba(0, 0, 0, 0.6);">
            <div class="d-flex justify-content-center align-items-center">
                <div class="text-white">
                    <h1 class="mb-3">Hotel San Javier</h1>
                    <h4 class="mb-3">More than an hotel... an experience.</h4>
                    <form runat="server">
                        <asp:Button ID="Button2" runat="server" Text="LOG IN" OnClick="Button1_Click" CssClass="btn btn-outline-primary" />
                    </form>
                </div>
            </div>
        </div>
    </div>

    <div class="row align-middle">
        <div class="col-6" style="background-color: #7dffef;">
            <h2 class="align-middle"
                style="text-align: center; padding-top: 18%;">ACTIVE TOURISM</h2>
        </div>

        <div class="col-6" >
            <img class="w-100 img-fluid" src="https://turismo.sanjavier.es/wp-content/uploads/2019/07/deportes.jpg" alt="Alternate Text" />
        </div>

        <div class="col-6">
            <img src="https://turismo.sanjavier.es/wp-content/uploads/2019/09/alojamientos.jpg" alt="Alternate Text" />
        </div>

        <div class="col-6" style="background-color: #7dffef;">
            <h2 class="align-middle text-dark-50 justify-content-center text-center"
                style="text-align: center; padding-top: 18%; justify-content: center">ACCOMMODATION</h2>
        </div>
        

        <div class="col-6" style="background-color: #7dffef;">
            <h2 class="align-middle"
                style="text-align: center; padding-top: 18%;">SITES OF INTEREST</h2>
        </div>

        <div class="col-6">
            <img class=" img-fluid" src="https://turismo.sanjavier.es/wp-content/uploads/2019/07/sitio-interes.jpg" alt="Alternate Text" />
        </div>

        <div class="col-6">
            <img src="https://turismo.sanjavier.es/wp-content/uploads/2019/07/bodas.jpg" alt="Alternate Text" />
        </div>

        <div class="col-6" style="background-color: #7dffef;">
            <h2 class="align-middle"
                style="text-align: center; padding-top: 18%;">WEDDINGS</h2>
        </div>
        
        <div class="col-6" style="background-color: #7dffef;">
            <h2 class="align-middle"
                style="text-align: center; padding-top: 18%;">RESTAURANTS</h2>
        </div>
        <div class="col-6">
            <img class=" img-fluid" src="https://turismo.sanjavier.es/wp-content/uploads/2019/07/restaurantes.jpg" alt="Alternate Text" />
        </div>
    </div>
    <!-- Background image -->
</asp:Content>
