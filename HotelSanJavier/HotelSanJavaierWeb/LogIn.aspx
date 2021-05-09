<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HotelSanJavaierWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- CSS only -->
    <link href="Login.css" rel="stylesheet" />
    <link href="main.css" rel="stylesheet" />
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
</head>
<body>

     <div class="header">
        <div class="header-left align-middle">
            <img src="https://turismo.sanjavier.es/wp-content/uploads/2019/07/ESTRELLA-TURISMO-logo-negro-1.png" alt="Alternate Text" />
        </div>

        <div class="header-right align-middle">
            <a class="active" href="Home.aspx">Home</a>
            <a href="#contact">Contact</a>
            <a href="LogIn.aspx">Log in</a>
        </div>
    </div>

    <div class="container wrapper fadeInDown">
      <div id="formContent" style="margin-top: 5%;">
            <!-- Tabs Titles -->
            <h2 class="text-dark" style="
                margin-bottom: 10px;"> Sign In </h2>
          </div>
            
        
           <form id="formClients" runat="server">
               <div class="row">
                    <div class="col-6">
                        <div class=" text-center mt-2">
                            <h3>Log in as a client</h3>
                            <asp:TextBox type="text" ID="dniClient" class="fadeIn second" placeholder="DNI" runat="server"></asp:TextBox>
                            <asp:TextBox type="text" ID="passwordClient" runat="server" class="fadeIn third" name="login" placeholder="PASSWORD"></asp:TextBox>
                            <asp:Button type="submit" class="fadeIn fourth align-middle" value="Log In" ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
                        </div>
    
                        </div>

                    <div class="col-6">
                        <div class=" text-center mt-2">
                            <h3>Log in as a receptionist</h3>
                            <asp:TextBox type="text" ID="dniRecepcionist" class="fadeIn second" placeholder="DNI" runat="server"></asp:TextBox>
                            <asp:TextBox type="text" ID="passwordRecepcionist" runat="server" class="fadeIn third" name="login" placeholder="PASSWORD"></asp:TextBox>
                            <asp:Button type="submit" class="fadeIn fourth align-middle" value="Log In" ID="Button2" runat="server" text="Log in" OnClick="Button2_Click" />
                        </div>
    
                    </div>
                 </div>
            </form>
       </div>
    
    <!-- Footer -->
    <footer class="page-footer font-small blue pt-4 text-white align-bottom">

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
