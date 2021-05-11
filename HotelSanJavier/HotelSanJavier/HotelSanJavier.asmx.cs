using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SQLite;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace HotelSanJavier
{
    /// <summary>
    /// Descripción breve de HotelSanJavier
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    
    public class HotelSanJavier : System.Web.Services.WebService
    {
       

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataTable getClients()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();
          

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM clients", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }


            return dt;
        }

        [WebMethod]
        public DataTable getReceptionists()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();


            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM recepcionists", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }


            return dt;
        }

        [WebMethod]
        public DataTable getClientsByReceptionist(int idReceptionist)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();


            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM clients WHERE id_receptionist =" + idReceptionist + " ;", conn); ;
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }


            return dt;
        }

        [WebMethod]
        public bool loginClient(string dni, string password)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM clients WHERE `dni` = '"+dni+ "' AND `password` = '"+password+"' ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }

            if (dt.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        [WebMethod]
        public DataTable getClient(string dni)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM clients WHERE `dni` = '" + dni + "' ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }

            return dt;

        }


        [WebMethod]
        public DataTable getReceptionist(string dni)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM recepcionists WHERE `dni` = '" + dni + "' ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);

                conn.Close();
              
            }

            return dt;

        }

        [WebMethod]
        public DataTable getReceptionistById(string id)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM recepcionists WHERE `id` = '" + id + "' ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);

                conn.Close();

            }

            return dt;

        }
        [WebMethod]
        public bool loginReceptionist(string dni, string password)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM recepcionists WHERE `dni` = '" + dni + "' AND `password` = '" + password + "' ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            if (dt.Rows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        [WebMethod]
        public DataTable getReservetionsByClient(string dniClient)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations WHERE `dni_client` = '" + dniClient + "' ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;


        }


        [WebMethod]
        public DataTable getReservetionsByReceptionist(string idReceptionist)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                    conn.Open();
                    SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations WHERE `id_receptionist` = '" + idReceptionist + "' ;", conn);
                    SQLiteDataReader reader = comm.ExecuteReader();
                    dt.Load(reader);
                    conn.Close();
            }
            return dt;


        }


        [WebMethod]
        public DataTable getReservetionsById(int id)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations WHERE `id` = " + id + " ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;


        }


        [WebMethod]
        public DataTable getAllReservetions()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            return dt;

        }

        [WebMethod]
        public void addClient(string dni, string password, int telephone, string name, string surname, string email, int id_receptionist)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");
            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("INSERT INTO clients(dni, password, telephone, name, surname, email, id_receptionist) VALUES('" + dni + "', '" + password + "', '" + telephone + "', '" + name + "', '" + surname + "', '"+email+"', "+id_receptionist+" );", conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        [WebMethod]
        public void addReservation(string dni_client, int id_receptionist, string entry_date, string exit_date, int id_room)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("INSERT INTO reservations(dni_client, id_receptionist, entry_date, exit_date, id_room) VALUES('" + dni_client + "', '" + id_receptionist + "', '" + entry_date + "', '" + exit_date + "', "+ id_room + " );", conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        [WebMethod]
        public void addRecepcionists(string name, string surname, string dni, int rol, string password)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("INSERT INTO recepcionists(name, last_name, dni, rol, password) VALUES('"+name+"', '"+surname+"', '"+dni+"', '"+rol+"', '"+password+"');", conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }

        }

        [WebMethod]
        public void editRecepcionists()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }

        }

        [WebMethod]
        public void editClient( string dni, string password, int telephone, string name, string surname, string email, int id_receptionist)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");
            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("UPDATE  clients SET password = '"+password+"', telephone = "+telephone+", name = '"+name+"', surname = '"+surname+"', email ='"+email+"', id_receptionist = "+id_receptionist+" WHERE dni = '"+dni+"' ;", conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        [WebMethod]
        public void editReservation(int idReservation, string dni_client, int id_receptionist, string entry_date, string exit_date, int id_room)
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("UPDATE reservations SET dni_client = '"+dni_client+"', id_receptionist ="+id_receptionist+", entry_date = '" + entry_date +"', exit_date = '"+exit_date+"', id_room = "+id_room+" WHERE id ="+idReservation+";", conn);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.InsertCommand = comm;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        [WebMethod]
        public void removeRecepcionists()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }

        }

        [WebMethod]
        public void removeClient()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }

        }


        [WebMethod]
        public void removeReservation()
        {
            string DBpath = Server.MapPath("HotelSanJavier.db");

            DataTable dt = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBpath + ";Version=3;"))
            {
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand("SELECT * FROM reservations ;", conn);
                SQLiteDataReader reader = comm.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }

        }
    }
}
