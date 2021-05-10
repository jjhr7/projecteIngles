using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelSanJavaierWeb
{
    public partial class LoggedMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Session["authentication"] = false;
            Session["dniClient"] = null;
            Session["idReceptionist"] = null;
            Response.Redirect("../LogInPage.aspx");
        }
    }
}