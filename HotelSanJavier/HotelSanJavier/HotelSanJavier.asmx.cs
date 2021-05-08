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
    }
}
