using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelSanJavaierWeb
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["authentication"] = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./LogInPage.aspx");
        }
    }
}