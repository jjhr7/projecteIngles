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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            string dniClient = Request.QueryString["dniClient"];
            
            Label1.Text = "Client DNI:"+dniClient;

            DataTable listReservas = ws.getReservetionsByClient(dniClient);

            

            StringBuilder sb = new StringBuilder();
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
            sb.Append("<tbody id=\"reservationsData\">");

            foreach (DataRow dr in listReservas.Rows)
            {
                sb.Append("<tr>");
                sb.Append("<th scope=\"row\">"+dr["id"].ToString()+"</th>");
                sb.Append("<td>"+dr["dni_client"].ToString()+"</td>");
                sb.Append("<td>"+dr["id_receptionist"].ToString()+"</td>");
                sb.Append("<td>"+dr["entry_date"].ToString()+"</td>");
                sb.Append("<td>"+dr["exit_date"].ToString()+"</td>");
                sb.Append("<td>"+dr["id_room"].ToString()+"</td>");
                sb.Append("</tr>");

                //idReserves += dr["id"].ToString();

            }

            sb.Append("</tbody>");
            sb.Append("</table>");
            Panel1.Controls.Add(new Label {Text =sb.ToString() });




        }
    }
}