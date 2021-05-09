<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HotelSanJavaierWeb.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
    <link href="main.css" rel="stylesheet" />
</head>
<body>


    <div class="header">
        <div class="header-left align-middle">
            <img src="https://turismo.sanjavier.es/wp-content/uploads/2019/07/ESTRELLA-TURISMO-logo-negro-1.png" alt="Alternate Text" />
        </div>

        <div class="header-right align-middle">
            <a class="active" href="#home">Home</a>
            <a href="#contact">Contact</a>
            <a href="#about">Log in</a>
        </div>
    </div>


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
                        <asp:Button ID="Button2" runat="server" Text="LOG IN" OnClick="Button1_Click" CssClass="btn btn-outline-light btn-lg mb-2" />
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
            <h2 class="align-middle"
                style="text-align: center; padding-top: 18%;">ACCOMMODATION</h2>
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

    <!-- Footer -->
    <footer class="page-footer font-small blue pt-4 text-white">

        <!-- Footer Links -->
        <div class="container-fluid text-center text-md-left">

            <!-- Grid row -->
            <div class="row">

                <!-- Grid column -->
                <div class="col-md-6 mt-md-0 mt-3">

                    <!-- Content -->
                    <h5 class="text-uppercase">Contact information</h5>
                    <p>Call us to make a reservation</p>
                    <p>+34615271860</p>

                </div>

                <div class="col-md-6 mt-md-0 mt-3">

                    <!-- Links -->
                    <h5 class="text-uppercase">More</h5>

                    <div class="footer-copyright text-center py-3">
                        © 2020 HotelSanJavier:
            <p>HotelSanJavier.com</p>

                    </div>
                    <!-- Grid column -->

                </div>
                <!-- Grid column -->

                <!-- Copyright -->
                <!-- Copyright -->
    </footer>
    <!-- Footer -->
</body>
</html>
