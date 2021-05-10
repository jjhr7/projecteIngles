using System;
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
    public partial class ReceptionistsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            string idReceptionist = Request.QueryString["idReceptionist"];

            string nameReceptionist = "";
            DataTable dataReceptionist = ws.getReceptionist(idReceptionist);
            foreach (DataRow dr in dataReceptionist.Rows)
            {
                nameReceptionist = dr["name"].ToString();
            }

            DataTable listReservations;
            DataTable listClients;

            if (Int32.Parse(idReceptionist) == 1)
            {
                listReservations = ws.getAllReservetions();
                listClients = ws.getClients();
                DataTable listReceptionist= ws.getReceptionists();

                StringBuilder sb3 = new StringBuilder();
                sb3.Append(" <h2>List of Receptionists</h2>");
                sb3.Append("<table class=\"table table-striped\" id=\"listReservations\">");
                sb3.Append("<thead class=\"thead-dark\">");
                sb3.Append("<tr>");
                sb3.Append("<th scope=\"col\">ID RECEPTIONIST</th>");
                sb3.Append("<th scope=\"col\">NAME RECEPTIONIST</th>");
                sb3.Append("<th scope=\"col\">SURNAME RECEPTIONS</th>");
                sb3.Append("<th scope=\"col\">DNI RECEPTIONIST</th>");
                sb3.Append("<th scope=\"col\">ROL RECEPTIONIST</th>");
                sb3.Append("</tr>");
                sb3.Append("</thead>");
                sb3.Append("<tbody id=\"reservationsData\">");

                foreach (DataRow dr in listReceptionist.Rows)
                {
                    sb3.Append("<tr>");
                    sb3.Append("<th scope=\"row\">" + dr["id"].ToString() + "</th>");
                    sb3.Append("<td>" + dr["name"].ToString() + "</td>");
                    sb3.Append("<td>" + dr["last_name"].ToString() + "</td>");
                    sb3.Append("<td>" + dr["dni"].ToString() + "</td>");
                    sb3.Append("<td>" + dr["rol"].ToString() + "</td>");
                    sb3.Append("</tr>");

                }

                sb3.Append("</tbody>");
                sb3.Append("</table>");
                Panel4.Controls.Add(new Label { Text = sb3.ToString() });
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
            sb.Append("<th scope=\"col\">DNI CLIENT</th>");
            sb.Append("<th scope=\"col\">ID RECEPTIONIST</th>");
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

            if (rolReceptionistCast == 1)
            {
                string name = nameReceptionist.Text;
                string lastname = lasnameReceptionist.Text;
                string dni = dniReceptionist.Text;
                int rol = Int32.Parse(rolReceptionist.Text);
                string password = passwordReceptionist.Text;
                ws.addRecepcionists(name, lastname, dni, rol, password);


            }
            Panel1.Controls.Clear();
            Panel2.Controls.Clear();
            Panel4.Controls.Clear();
            Page_Load(this,null);
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

            Panel1.Controls.Clear();
            Panel2.Controls.Clear();
            Panel4.Controls.Clear();
            Page_Load(this, null);
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

            ws.addClient(dniClient, password, Int32.Parse(telephone), nameClient, surname, email, idReceptionist);

            Panel1.Controls.Clear();
            Panel2.Controls.Clear();
            Panel4.Controls.Clear();
            Page_Load(this, null);
        }

        protected void Edit_Button(object sender, EventArgs e)
        {
            
        }

        protected void EditReservatio_Click(object sender, EventArgs e)
        {
            
        }

        protected void EditClient_Click(object sender, EventArgs e)
        {

        }

        protected void EditReceptionist_Click(object sender, EventArgs e)
        {
            


        }
    }
}