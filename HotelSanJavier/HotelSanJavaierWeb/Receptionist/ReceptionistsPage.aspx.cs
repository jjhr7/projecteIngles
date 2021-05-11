using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelSanJavaierWeb.referencia1;
using System.Data;
using System.Text;
using HotelSanJavaierWeb.Receptionist;
using Newtonsoft.Json;
using System.IO;

namespace HotelSanJavaierWeb
{
    public partial class ReceptionistsPage : System.Web.UI.Page
    {
        List<Reserve> reservations = new List<Reserve>();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*findDataToEdit.Text = "";
            dniClientEdit.Text = "";
            idReceptionistEdit.Text = "";
            entryDateEdit.Text = "";
            exitDateEdit.Text = "";
            idRoomEdit.Text = "";
            findClientUpdate.Text = "";
            passwordClientUpdate.Text = "";
            telephoneClientUpdate.Text = "";
            nameClietnUpdate.Text = "";
            surnameClientUpdate.Text = "";
            emailClientUpdate.Text = "";
            idReceptionistClientUpdate.Text = "";
            nameReceptionistToEdit.Text = "";
            surnameReceptionistToEdit.Text = "";
            dniReceptionistToUpdate.Text = "";
            rolReceptionistToEdit.Text = "";
            passReceptionistToEdit.Text = "";*/
            try
            {
                if (!(bool)Session["authentication"])
                {
                    Response.Redirect("../LogInPage.aspx");
                }
            }
            catch(Exception err)
            {
                Response.Redirect("../LogInPage.aspx");
            }
            
            HotelSanJavier ws = new HotelSanJavier();
            string idReceptionist = Session["idReceptionist"].ToString();

            string nameReceptionist = "";
            DataTable dataReceptionist = ws.getReceptionist(idReceptionist);
            foreach (DataRow dr in dataReceptionist.Rows)
            {
                nameReceptionist = dr["name"].ToString();
            }

            DataTable listReservations;
            DataTable listClients;

            listReservations = ws.getAllReservetions();
            listClients = ws.getClients();
            DataTable listReceptionist = ws.getReceptionists();
            try
            {
                if (Int32.Parse(idReceptionist) == 1)
                {

                    

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
                    EditReceptionist.Visible = true;
                }
                else
                {
                    listReservations = ws.getReservetionsByReceptionist(idReceptionist);
                    listClients = ws.getClientsByReceptionist(Int32.Parse(idReceptionist));
                }
            }
            catch(Exception err)
            {

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
                Reserve reservation  = new Reserve(Int32.Parse(dr["id"].ToString()), dr["dni_client"].ToString(), Int32.Parse(dr["id_receptionist"].ToString()), dr["entry_date"].ToString(), dr["exit_date"].ToString(), Int32.Parse(dr["id_room"].ToString()));
                sb.Append("<tr>");
                sb.Append("<th scope=\"row\">" + dr["id"].ToString() + "</th>");
                sb.Append("<td>" + dr["dni_client"].ToString() + "</td>");
                sb.Append("<td>" + dr["id_receptionist"].ToString() + "</td>");
                sb.Append("<td>" + dr["entry_date"].ToString() + "</td>");
                sb.Append("<td>" + dr["exit_date"].ToString() + "</td>");
                sb.Append("<td>" + dr["id_room"].ToString() + "</td>");
                sb.Append("</tr>");
                reservations.Add(reservation);

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
            try
            {
                HotelSanJavier ws = new HotelSanJavier();
                string idReceptionist = Session["idReceptionist"].ToString();
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
                Page_Load(this, null);
            }
            catch (Exception err)
            {

            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();
                string idReceptionist = Session["idReceptionist"].ToString();

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
            catch(Exception err)
            {

            }
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();
                int idReceptionist = Int32.Parse(Session["idReceptionist"].ToString());

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
            catch (Exception err)
            {
                
            }
            
        }
        protected void EditReservatio_Click(object sender, EventArgs e)
        {
            idReservationEdit.Visible = true;
            findDataToEdit.Visible = true;

            ApplyReceptionistUpdate.Visible = false;
            ApplyClientUpdate.Visible = false;
            findClientUpdate.Visible = false;
            dniClientEdit.Visible = false;
            idReceptionistEdit.Visible = false;
            entryDateEdit.Visible = false;
            exitDateEdit.Visible = false;
            idRoomEdit.Visible = false;
            findClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            telephoneClientUpdate.Visible = false;
            nameClietnUpdate.Visible = false;
            surnameClientUpdate.Visible = false;
            emailClientUpdate.Visible = false;
            idReceptionistClientUpdate.Visible = false;
            nameReceptionistToEdit.Visible = false;
            surnameReceptionistToEdit.Visible = false;
            dniReceptionistToUpdate.Visible = false;
            rolReceptionistToEdit.Visible = false;
            passReceptionistToEdit.Visible = false;
            idReceptionistToEdit.Visible = false;
            findReceptionistUpdate.Visible = false;


            dniClientEdit.Visible = false;
            idReceptionistEdit.Visible = false;
            entryDateEdit.Visible = false;
            exitDateEdit.Visible = false;
            idRoomEdit.Visible = false;
            findClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            telephoneClientUpdate.Visible = false;
            nameClietnUpdate.Visible = false;
            surnameClientUpdate.Visible = false;
            emailClientUpdate.Visible = false;
            idReceptionistClientUpdate.Visible = false;
            nameReceptionistToEdit.Visible = false;
            surnameReceptionistToEdit.Visible = false;
            dniReceptionistToUpdate.Visible = false;
            rolReceptionistToEdit.Visible = false;
            passReceptionistToEdit.Visible = false;
            idReceptionistToEdit.Visible = false;
            findReceptionistUpdate.Visible = false;

            dniClientUpdate.Visible = false;
           

        }

        protected void EditClient_Click(object sender, EventArgs e)
        {
            dniClientUpdate.Visible = true;
            findClientUpdate.Visible = true;
            dniClientEdit.Visible = false;

            ApplyEdit.Visible = false;
            idReceptionistToEdit.Visible = false;
            findReceptionistUpdate.Visible = false;
            findDataToEdit.Visible = false;
            idReservationEdit.Visible = false;
            idReceptionistEdit.Visible = false;
            entryDateEdit.Visible = false;
            exitDateEdit.Visible = false;
            idRoomEdit.Visible = false;
            passwordClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            telephoneClientUpdate.Visible = false;
            nameClietnUpdate.Visible = false;
            surnameClientUpdate.Visible = false;
            emailClientUpdate.Visible = false;
            idReceptionistClientUpdate.Visible = false;
            nameReceptionistToEdit.Visible = false;
            surnameReceptionistToEdit.Visible = false;
            dniReceptionistToUpdate.Visible = false;
            rolReceptionistToEdit.Visible = false;
            passReceptionistToEdit.Visible = false;
            ApplyReceptionistUpdate.Visible = false;
        }

        protected void EditReceptionist_Click(object sender, EventArgs e)
        {
            idReceptionistToEdit.Visible = true;
            findReceptionistUpdate.Visible = true;
            dniClientEdit.Visible = false;

            ApplyEdit.Visible = false;
            ApplyClientUpdate.Visible = false;
            dniClientUpdate.Visible = false;
            findDataToEdit.Visible = false;
            idReservationEdit.Visible = false;
            idReceptionistEdit.Visible = false;
            entryDateEdit.Visible = false;
            exitDateEdit.Visible = false;
            idRoomEdit.Visible = false;
            findClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            passwordClientUpdate.Visible = false;
            telephoneClientUpdate.Visible = false;
            nameClietnUpdate.Visible = false;
            surnameClientUpdate.Visible = false;
            emailClientUpdate.Visible = false;
            idReceptionistClientUpdate.Visible = false;
            nameReceptionistToEdit.Visible = false;
            surnameReceptionistToEdit.Visible = false;
            dniReceptionistToUpdate.Visible = false;
            rolReceptionistToEdit.Visible = false;
            passReceptionistToEdit.Visible = false;
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(reservations);

            try
            {
                var dataFile = Server.MapPath("Reservations.json");
                File.WriteAllText(@dataFile, json);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        protected void findDataToEdit_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();
                DataTable reservationData = ws.getReservetionsById(Int32.Parse(idReservationEdit.Text.ToString()));
                idReservationEdit.Enabled = false;
                dniClientEdit.Visible = true;
                idReceptionistEdit.Visible = true;
                entryDateEdit.Visible = true;
                exitDateEdit.Visible = true;
                idRoomEdit.Visible = true;
                ApplyEdit.Visible = true;
                findDataToEdit.Visible = false;
                idReservationEdit.Visible = false;

                foreach (DataRow dr in reservationData.Rows)
                {
                    dniClientEdit.Text = dr["dni_client"].ToString();
                    idReceptionistEdit.Text = dr["id_receptionist"].ToString();
                    entryDateEdit.Text = dr["entry_date"].ToString();
                    exitDateEdit.Text = dr["exit_date"].ToString();
                    idRoomEdit.Text = dr["id_room"].ToString();


                }
            }
            catch(Exception err)
            {

            }
            
        }

        protected void ApplyEdit_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();

                int idReservationEdited = Int32.Parse(idReservationEdit.Text.ToString());
                string dniClientEdited = dniClientEdit.Text.ToString();
                int idReceptionistEdited = Int32.Parse(idReceptionistEdit.Text.ToString());
                string entryDateEdited = entryDateEdit.Text.ToString();
                string exitDateEdited = exitDateEdit.Text.ToString();
                int idRoomEdited = Int32.Parse(idRoomEdit.Text.ToString());

                ws.editReservation(idReservationEdited, dniClientEdited, idReceptionistEdited, entryDateEdited, exitDateEdited, idRoomEdited);

                Panel1.Controls.Clear();
                Panel2.Controls.Clear();
                Panel4.Controls.Clear();
                Page_Load(this, null);

                dniClientEdit.Visible = false;
                idReceptionistEdit.Visible = false;
                entryDateEdit.Visible = false;
                exitDateEdit.Visible = false;
                idRoomEdit.Visible = false;
                ApplyEdit.Visible = false;
            }
            catch (Exception err)
            {

            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();
                DataTable clientToEditData = ws.getClient(dniClientUpdate.Text.ToString());
                dniClientUpdate.Enabled = false;
                passwordClientUpdate.Visible = true;
                telephoneClientUpdate.Visible = true;
                nameClietnUpdate.Visible = true;
                surnameClientUpdate.Visible = true;
                emailClientUpdate.Visible = true;
                dniClientEdit.Visible = false;
                findClientUpdate.Visible = false;
                dniClientUpdate.Visible = false;

                if (Int32.Parse(Session["idReceptionist"].ToString()) != 1)
                {
                    idReceptionistClientUpdate.Visible = true;
                    idReceptionistClientUpdate.Enabled = false;
                }
                else
                {
                    idReceptionistClientUpdate.Visible = true;
                }

                foreach (DataRow dr in clientToEditData.Rows)
                {
                    passwordClientUpdate.Text = dr["password"].ToString();
                    telephoneClientUpdate.Text = dr["telephone"].ToString();
                    nameClietnUpdate.Text = dr["name"].ToString();
                    surnameClientUpdate.Text = dr["surname"].ToString();
                    emailClientUpdate.Text = dr["email"].ToString();
                }
                idReceptionistClientUpdate.Text = Session["idReceptionist"].ToString();
                ApplyClientUpdate.Visible = true;
            } 
            catch(Exception err)
            {

            }
            
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();
                DataTable receptionistToEdit = ws.getReceptionist(idReceptionistToEdit.Text.ToString());
                nameReceptionistToEdit.Enabled = false;
                surnameReceptionistToEdit.Visible = true;
                dniReceptionistToUpdate.Visible = true;
                rolReceptionistToEdit.Visible = true;
                passReceptionistToEdit.Visible = true;
                dniClientEdit.Visible = false;
                dniClientUpdate.Visible = false;
                findReceptionistUpdate.Visible = false;
                idReceptionistToEdit.Visible = false;

                if (Int32.Parse(Session["idReceptionist"].ToString()) != 1)
                {
                    passReceptionistToEdit.Visible = true;
                    passReceptionistToEdit.Enabled = false;
                }
                else
                {
                    passReceptionistToEdit.Visible = true;
                }

                foreach (DataRow dr in receptionistToEdit.Rows)
                {
                    nameReceptionistToEdit.Text = dr["name"].ToString();
                    surnameReceptionistToEdit.Text = dr["last_name"].ToString();
                    dniReceptionistToUpdate.Text = dr["dni"].ToString();
                    rolReceptionistToEdit.Text = dr["rol"].ToString();
                    passReceptionistToEdit.Text = dr["password"].ToString();
                }
                idReceptionistToEdit.Text = Session["idReceptionist"].ToString();
                ApplyReceptionistUpdate.Visible = true;
            } 
            catch(Exception err)
            {

            }
            
        }



        protected void ApplyClientUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();

                string dniClientEdited = dniClientUpdate.Text.ToString();
                string passClientEdited = passwordClientUpdate.Text.ToString();
                int telefClientEdited = Int32.Parse(telephoneClientUpdate.Text.ToString());
                string nameCliendEdited = nameClietnUpdate.Text.ToString();
                string surnameClientEdited = surnameClientUpdate.Text.ToString();
                string emailClientEdited = emailClientUpdate.Text.ToString();
                int idReceptcionistEdited = Int32.Parse(Session["idReceptionist"].ToString());

                ws.editClient(dniClientEdited, passClientEdited, telefClientEdited, nameCliendEdited, surnameClientEdited, emailClientEdited, idReceptcionistEdited);

                Panel1.Controls.Clear();
                Panel2.Controls.Clear();
                Panel4.Controls.Clear();
                Page_Load(this, null);
            } catch(Exception err)
            {

            }
           
        }

        protected void ApplyReceptionistUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                HotelSanJavier ws = new HotelSanJavier();

                string nameRecep = nameReceptionistToEdit.Text.ToString();
                string surnameRecep = surnameReceptionistToEdit.Text.ToString();
                int rolRecep = Int32.Parse(rolReceptionistToEdit.Text.ToString());
                string passRecep = passReceptionistToEdit.Text.ToString();
                string dniRecep = surnameClientUpdate.Text.ToString();
                int idReceptcionistEdited = Int32.Parse(Session["id"].ToString());

                ws.editReceptionist(idReceptcionistEdited, nameRecep, surnameRecep, dniRecep, rolRecep, passRecep);

                Panel1.Controls.Clear();
                Panel2.Controls.Clear();
                Panel4.Controls.Clear();
                Page_Load(this, null);
            }
            catch (Exception err)
            {

            }

        }

    }
}