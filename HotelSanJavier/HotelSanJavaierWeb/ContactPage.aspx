<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="HotelSanJavaierWeb.ContactPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div
        class="divImg p-5 text-center bg-image">
    <div><h1>Contact Us</h1></div>
    <br />
    <div class="row m-2">
        <div class="col-md-5">
            <div id="googlemap" style="width:100%; height:350px; background-image: url(https://pix10.agoda.net/hotelImages/124/1246280/1246280_16061017110043391702.jpg?s=1024x768); background-repeat: no-repeat; background-size: cover"></div>
        </div>
        <div class="col-md-2"></div>
        <br />
        <div class="col-md-5 align-middle form-text" style="background-color: rgba(0,0,0,0.2); border-radius: 2px 2px;">
            <form class="my-form m-2">
                <div class="form-group">
                    <input type="text" class="form-control" id="form-name" placeholder="Name">
                </div>
                <div class="form-group">
                    <input type="text" class="form-control" id="form-email" placeholder="Email Address">
                </div>
                <div class="form-group" style=" margin-bottom: 3px;">
                    <input type="text" class="form-control" id="form-subject" placeholder="Subject">
                </div>
                <div class="form-group">
                    <textarea class="form-control" id="form-message" placeholder="Message"></textarea>
                </div>
                <div class="form-group" style="margin-top: 20px;">
                    <button type="button" class="btn btn-info">Contact Us</button> 
                </div>
                               
            </form>
        </div>
    </div>
</div>
</asp:Content>
