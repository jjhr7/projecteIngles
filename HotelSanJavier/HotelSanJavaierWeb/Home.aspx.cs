using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;
using System.Data.SQLite;
using System.Data;

namespace HotelSanJavaierWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();

            DataTable listaClientes = ws.getClients();

            DataTable dt = ws.getClients();


            foreach (DataRow dr in dt.Rows)
            {
                TextBox1.Text = dr["name"].ToString();
            }
        }
    }
}