using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;
using System.Data;
using System.Windows.Forms;

namespace HotelSanJavaierWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();
            string dniClient = Request.QueryString["dniClient"];
            string idReserves="";
            Label1.Text = dniClient;

            DataTable listReservas = ws.getReservetionsByClient(dniClient);

            foreach (DataRow dr in listReservas.Rows)
            {
                idReserves += dr["id"].ToString();

            }
            Label1.Text = idReserves;

            //HtmlDocument doc = WebBrowser.Document;




        }
    }
}