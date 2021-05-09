using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;
using System.Data;

namespace HotelSanJavaierWeb
{
    public partial class LogInPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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


                Response.Redirect("./ClientsPage.aspx?dniClient=" + dniClient);
            }
            else
            {
                //TextBox3.Text = existe + "";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HotelSanJavier ws = new HotelSanJavier();

            string dniR = dniRecepcionist.Text;
            string passwordR = passwordRecepcionist.Text;

            bool existe = ws.loginReceptionist(dniR, passwordR);

            //TextBox4.Text = existe + "";

            DataTable receptionistData;

            if (existe)
            {

                string idReceptionist = "";
                receptionistData = ws.getReceptionist(dniR);



                foreach (DataRow dr in receptionistData.Rows)
                {
                    idReceptionist = dr["id"].ToString();

                }

                Response.Redirect("./ReceptionistPage.aspx?idReceptionist=" + idReceptionist);

            }
            else
            {
                //TextBox4.Text = existe + "";
            }
        }
    }
}