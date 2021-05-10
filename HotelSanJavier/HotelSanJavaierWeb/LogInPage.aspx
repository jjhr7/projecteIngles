<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogInPage.aspx.cs" Inherits="HotelSanJavaierWeb.LogInPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" class="bodyLogin">
    <body>
        <div class="container wrapper fadeInDown">
      <div id="formContent">
            <h2 class="active classTxtLogIn text-white">Sign In</h2>
          </div>
            
        
           <form id="formClients" runat="server">
               <div class="row">
                    <div class="col-6">
                        <div class=" text-center mt-2">
                            <h3>Log in as a client</h3>
                            <asp:TextBox type="text" ID="dniClient" class="fadeIn second" placeholder="DNI" runat="server"></asp:TextBox>
                            <asp:TextBox type="password" ID="passwordClient" runat="server" class="classPass fadeIn third" name="login" placeholder="PASSWORD"></asp:TextBox>
                            <asp:Button type="submit" class="fadeIn fourth align-middle" value="Log In" ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
                        </div>
    
                        </div>

                    <div class="col-6">
                        <div class=" text-center mt-2">
                            <h3>Log in as a receptionist</h3>
                            <asp:TextBox type="text" ID="dniRecepcionist" class="fadeIn second" placeholder="DNI" runat="server"></asp:TextBox>
                            <asp:TextBox type="password" ID="passwordRecepcionist" runat="server" class="classPass fadeIn third" name="login" placeholder="PASSWORD"></asp:TextBox>
                            <asp:Button type="submit" class="fadeIn fourth align-middle" value="Log In" ID="Button2" runat="server" text="Log in" OnClick="Button2_Click" />
                        </div>
    
                    </div>
                 </div>
            </form>
       </div>

    </body>
    
</asp:Content>
