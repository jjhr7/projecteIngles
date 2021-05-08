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
            string[] listaClientes = { };
          

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
    }
}
