using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Web.Security;
using System.Security.Permissions;

namespace HotelSanJavaierWeb
{
    public partial class LogInPage : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["authentication"] = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();

            string dniC = dniClient.Text;
            string passwordC = passwordClient.Text;

           bool existe = ws.loginClient(dniC, passwordC);
            DataTable clientData;

            if (existe)
            {
                string dniClient = "";
                clientData = ws.getClient(dniC);



                foreach (DataRow dr in clientData.Rows)
                {
                    dniClient = dr["dni"].ToString();

                }

                FormsAuthentication.SetAuthCookie("user", true);
                Session["authentication"] = true;
                Session["dniClient"] = dniClient;
                Response.Redirect("./Client/ClientsPage.aspx");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect credentials", "Please, try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();

            string dniR = dniRecepcionist.Text;
            string passwordR = passwordRecepcionist.Text;

            bool existe = ws.loginReceptionist(dniR, passwordR);


            DataTable receptionistData;

            if (existe)
            {

                string idReceptionist = "";
                receptionistData = ws.getReceptionist(dniR);



                foreach (DataRow dr in receptionistData.Rows)
                {
                    idReceptionist = dr["id"].ToString();

                }
                FormsAuthentication.SetAuthCookie("admin", true);
                Session["authentication"] = true;
                Session["idReceptionist"] = idReceptionist;
                Response.Redirect("./Receptionist/ReceptionistsPage.aspx");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect credentials", "Please, try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}