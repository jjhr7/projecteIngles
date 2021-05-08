using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;

namespace HotelSanJavaierWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                string nameClient = Request.QueryString["idClient"];
                Label1.Text = nameClient;
           
            
        }
    }
}