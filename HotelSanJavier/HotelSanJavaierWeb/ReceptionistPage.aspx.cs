﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;
using System.Data;
using System.Text;

namespace HotelSanJavaierWeb
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            string idReceptionist = Request.QueryString["idReceptionist"];
            Label1.Text = "Id recepcionista: " + idReceptionist;
            DataTable listReservations;
            DataTable listClients;

            if (Int32.Parse(idReceptionist) == 1)
            {
                listReservations = ws.getAllReservetions();
                listClients = ws.getClients();
            }
            else
            {
                listReservations = ws.getReservetionsByReceptionist(idReceptionist);
                listClients = ws.getClientsByReceptionist(Int32.Parse(idReceptionist));
            }
            
           

            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            sb.Append("<table class=\"table table-striped\" id=\"listReservations\">");
            sb.Append("<thead class=\"thead-dark\">");
            sb.Append("<tr>");
            sb.Append("<th scope=\"col\">ID RESERVATION</th>");
            sb.Append("<th scope=\"col\">DNI CLIETN</th>");
            sb.Append("<th scope=\"col\">ID RECEPCIONIST</th>");
            sb.Append("<th scope=\"col\">ENTRY DATE</th>");
            sb.Append("<th scope=\"col\">EXIT DATE</th>");
            sb.Append("<th scope=\"col\">ID ROOM</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody id=\"reservationsData\">");

            foreach (DataRow dr in listReservations.Rows)
            {
                sb.Append("<tr>");
                sb.Append("<th scope=\"row\">" + dr["id"].ToString() + "</th>");
                sb.Append("<td>" + dr["dni_client"].ToString() + "</td>");
                sb.Append("<td>" + dr["id_receptionist"].ToString() + "</td>");
                sb.Append("<td>" + dr["entry_date"].ToString() + "</td>");
                sb.Append("<td>" + dr["exit_date"].ToString() + "</td>");
                sb.Append("<td>" + dr["id_room"].ToString() + "</td>");
                sb.Append("</tr>");

            }

            sb.Append("</tbody>");
            sb.Append("</table>");

            sb2.Append("<table class=\"table table-striped\" id=\"listClients\">");
            sb2.Append("<thead class=\"thead-dark\">");
            sb2.Append("<tr>");
            sb2.Append("<th scope=\"col\">DNI</th>");
            sb2.Append("<th scope=\"col\">TELEPHONE</th>");
            sb2.Append("<th scope=\"col\">NAME</th>");
            sb2.Append("<th scope=\"col\">SURNAME</th>");
            sb2.Append("<th scope=\"col\">EMAIL</th>");
            sb2.Append("<th scope=\"col\">ID RECEPTIONIST</th>");
            sb2.Append("</tr>");
            sb2.Append("</thead>");
            sb2.Append("<tbody id=\"clientssData\">");

            foreach (DataRow dr in listClients.Rows)
            {
                sb2.Append("<tr>");
                sb2.Append("<th scope=\"row\">" + dr["dni"].ToString() + "</th>");
                sb2.Append("<td>" + dr["telephone"].ToString() + "</td>");
                sb2.Append("<td>" + dr["name"].ToString() + "</td>");
                sb2.Append("<td>" + dr["surname"].ToString() + "</td>");
                sb2.Append("<td>" + dr["email"].ToString() + "</td>");
                sb2.Append("<td>" + dr["id_receptionist"].ToString() + "</td>");
                sb2.Append("</tr>");

            }

            sb2.Append("</tbody>");
            sb2.Append("</table>");




            Panel1.Controls.Add(new Label { Text = sb.ToString() });
            Panel2.Controls.Add(new Label { Text = sb2.ToString() });

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            string idReceptionist = Request.QueryString["idReceptionist"];
            int rolReceptionistCast = 0;
            DataTable receptionistData = ws.getReceptionistById(idReceptionist);

            foreach (DataRow dr in receptionistData.Rows)
            {
                rolReceptionistCast = Int32.Parse(dr["rol"].ToString());

            }
            Label2.Text += "El rol del usuario es"+rolReceptionistCast;

            if (rolReceptionistCast == 1)
            {
                string name = nameReceptionist.Text;
                string lastname = lasnameReceptionist.Text;
                string dni = dniReceptionist.Text;
                int rol = Int32.Parse(rolReceptionist.Text);
                string password = passwordReceptionist.Text;
                ws.addRecepcionists(name,lastname,dni,rol,password);
               

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            string idReceptionist = Request.QueryString["idReceptionist"];

            string dniClient = dni_client.Text;
            string entryDate = entry_date.Text;
            string exitDate = exit_date.Text;
            int idRoom = Convert.ToInt32(TextBox5.Text);
            
            ws.addReservation(dniClient, Convert.ToInt32(idReceptionist), entryDate, exitDate, idRoom);
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            int idReceptionist = Int32.Parse(Request.QueryString["idReceptionist"]);

            string dniClient = dniClientC.Text;
            string password = passwowrdClicentC.Text;
            string telephone = telephoneClientC.Text;
            string nameClient = clientNameC.Text;
            string surname = surnameClientC.Text;
            string email = emailClientC.Text;

            ws.addClient(dniClient, password, Int32.Parse(telephone), nameClient, surname, email,idReceptionist);


        }
    }
}